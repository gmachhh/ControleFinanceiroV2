using ControleFinanceiro.Data;
using ControleFinanceiro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly AppDbContext _context;

        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            var categorias = await _context.Categorias
                .OrderBy(c => c.Nome)
                .ToListAsync();

            return View(categorias);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return View(categoria);
            }

            bool existe = await _context.Categorias
                .AnyAsync(c =>
                    c.Nome.ToLower() ==
                    categoria.Nome.ToLower());

            if (existe)
            {
                ModelState.AddModelError(
                    "Nome",
                    "Essa categoria já existe.");

                return View(categoria);
            }

            _context.Categorias.Add(categoria);

            await _context.SaveChangesAsync();

            TempData["Sucesso"] =
                "Categoria cadastrada com sucesso!";

            return RedirectToAction(nameof(Index));
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categorias
                .FindAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
            int id,
            Categoria categoria)
        {
            if (id != categoria.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(categoria);
            }

            try
            {
                _context.Update(categoria);

                await _context.SaveChangesAsync();

                TempData["Sucesso"] =
                    "Categoria atualizada com sucesso!";
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriaExists(categoria.Id))
                {
                    return NotFound();
                }

                throw;
            }

            return RedirectToAction(nameof(Index));
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categorias
                .FirstOrDefaultAsync(c => c.Id == id);

            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(
            int id)
        {
            var categoria = await _context.Categorias
                .FindAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            bool possuiTransacoes =
                await _context.Transacoes
                    .AnyAsync(t => t.CategoriaId == id);

            if (possuiTransacoes)
            {
                TempData["Erro"] =
                    "Não é possível excluir uma categoria que possui transações.";

                return RedirectToAction(nameof(Index));
            }

            _context.Categorias.Remove(categoria);

            await _context.SaveChangesAsync();

            TempData["Sucesso"] =
                "Categoria excluída com sucesso!";

            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaExists(int id)
        {
            return _context.Categorias
                .Any(e => e.Id == id);
        }
    }
}