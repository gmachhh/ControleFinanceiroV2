using ControleFinanceiro.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControleFinanceiro.ViewModels;

public class TransacaoFiltroViewModel
{
    public string? Pesquisa { get; set; }

    public TipoTransacao? Tipo { get; set; }

    public int? CategoriaId { get; set; }

    public DateTime? DataInicial { get; set; }

    public DateTime? DataFinal { get; set; }

    public List<Transacao> Transacoes { get; set; } = new();

    public SelectList? Categorias { get; set; }
}