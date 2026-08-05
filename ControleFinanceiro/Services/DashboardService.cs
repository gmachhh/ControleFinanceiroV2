using ControleFinanceiro.Data;
using ControleFinanceiro.Interfaces;
using ControleFinanceiro.Models;
using ControleFinanceiro.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Services;

public class DashboardService : IDashboardService
{
    private readonly AppDbContext _context;

    public DashboardService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<DashboardViewModel> ObterDashboardAsync()
    {
        var transacoes = await _context.Transacoes
            .Include(t => t.Categoria)
            .OrderByDescending(t => t.Data)
            .ToListAsync();

        var model = new DashboardViewModel();

        model.TotalReceitas = transacoes
            .Where(t => t.Tipo == TipoTransacao.Receita)
            .Sum(t => t.Valor);

        model.TotalDespesas = transacoes
            .Where(t => t.Tipo == TipoTransacao.Despesa)
            .Sum(t => t.Valor);

        model.TotalTransacoes = transacoes.Count;

        model.UltimasTransacoes = transacoes
            .Take(5)
            .ToList();

        model.GastosPorCategoria = transacoes
            .Where(t => t.Tipo == TipoTransacao.Despesa)
            .GroupBy(t => t.Categoria!.Nome)
            .ToDictionary(
                g => g.Key,
                g => g.Sum(x => x.Valor));

        model.Categorias = model.GastosPorCategoria.Keys.ToList();

        model.ValoresCategorias = model.GastosPorCategoria.Values.ToList();

        var hoje = DateTime.Today;

        for (int i = 5; i >= 0; i--)
        {
            var mes = hoje.AddMonths(-i);

            model.Meses.Add(mes.ToString("MMM"));

            model.ReceitasMensais.Add(
                transacoes
                    .Where(t =>
                        t.Tipo == TipoTransacao.Receita &&
                        t.Data.Month == mes.Month &&
                        t.Data.Year == mes.Year)
                    .Sum(t => t.Valor));

            model.DespesasMensais.Add(
                transacoes
                    .Where(t =>
                        t.Tipo == TipoTransacao.Despesa &&
                        t.Data.Month == mes.Month &&
                        t.Data.Year == mes.Year)
                    .Sum(t => t.Valor));
        }

        return model;
    }
}