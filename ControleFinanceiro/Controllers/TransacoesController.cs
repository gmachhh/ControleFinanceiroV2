using ControleFinanceiro.Data;
using ControleFinanceiro.Models;
using ControleFinanceiro.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace ControleFinanceiro.Controllers
{
    public class TransacoesController : Controller
    {
        private readonly AppDbContext _context;

        public TransacoesController(AppDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index(
    string? pesquisa,
    TipoTransacao? tipo,
    int? categoriaId,
    DateTime? dataInicial,
    DateTime? dataFinal)
        {
            var query = _context.Transacoes
                .Include(t => t.Categoria)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(pesquisa))
            {
                query = query.Where(t =>
                    t.Descricao.Contains(pesquisa));
            }

            if (tipo.HasValue)
            {
                query = query.Where(t =>
                    t.Tipo == tipo.Value);
            }

            if (categoriaId.HasValue)
            {
                query = query.Where(t =>
                    t.CategoriaId == categoriaId);
            }

            if (dataInicial.HasValue)
            {
                query = query.Where(t =>
                    t.Data >= dataInicial.Value);
            }

            if (dataFinal.HasValue)
            {
                query = query.Where(t =>
                    t.Data <= dataFinal.Value);
            }

            var model = new TransacaoFiltroViewModel
            {
                Pesquisa = pesquisa,
                Tipo = tipo,
                CategoriaId = categoriaId,
                DataInicial = dataInicial,
                DataFinal = dataFinal,

                Categorias = new SelectList(
                    await _context.Categorias
                        .OrderBy(c => c.Nome)
                        .ToListAsync(),
                    "Id",
                    "Nome"),

                Transacoes = await query
                    .OrderByDescending(t => t.Data)
                    .ThenByDescending(t => t.Id)
                    .ToListAsync()
            };

            return View(model);
        }   

        
        public async Task<IActionResult> Create()
        {
            await CarregarCategorias();

            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            Transacao transacao)
        {
            if (!ModelState.IsValid)
            {
                await CarregarCategorias(transacao.CategoriaId);

                return View(transacao);
            }

            var categoriaExiste = await _context.Categorias
                .AnyAsync(c => c.Id == transacao.CategoriaId);

            if (!categoriaExiste)
            {
                ModelState.AddModelError(
                    "CategoriaId",
                    "A categoria selecionada não existe.");

                await CarregarCategorias(transacao.CategoriaId);

                return View(transacao);
            }

            _context.Transacoes.Add(transacao);

            await _context.SaveChangesAsync();

            TempData["Sucesso"] =
                "Transação cadastrada com sucesso!";

            return RedirectToAction(nameof(Index));
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transacao = await _context.Transacoes
                .FindAsync(id);

            if (transacao == null)
            {
                return NotFound();
            }

            await CarregarCategorias(transacao.CategoriaId);

            return View(transacao);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
            int id,
            Transacao transacao)
        {
            if (id != transacao.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                await CarregarCategorias(transacao.CategoriaId);

                return View(transacao);
            }

            try
            {
                _context.Update(transacao);

                await _context.SaveChangesAsync();

                TempData["Sucesso"] =
                    "Transação atualizada com sucesso!";
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransacaoExists(transacao.Id))
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

            var transacao = await _context.Transacoes
                .Include(t => t.Categoria)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (transacao == null)
            {
                return NotFound();
            }

            return View(transacao);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(
            int id)
        {
            var transacao = await _context.Transacoes
                .FindAsync(id);

            if (transacao == null)
            {
                return NotFound();
            }

            _context.Transacoes.Remove(transacao);

            await _context.SaveChangesAsync();

            TempData["Sucesso"] =
                "Transação excluída com sucesso!";

            return RedirectToAction(nameof(Index));
        }

        private async Task CarregarCategorias(
            int? categoriaSelecionada = null)
        {
            var categorias = await _context.Categorias
                .OrderBy(c => c.Nome)
                .ToListAsync();

            ViewBag.Categorias = new SelectList(
                categorias,
                "Id",
                "Nome",
                categoriaSelecionada);
        }

        private bool TransacaoExists(int id)
        {
            return _context.Transacoes
                .Any(e => e.Id == id);
        }
    }
}