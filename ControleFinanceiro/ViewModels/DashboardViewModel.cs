using ControleFinanceiro.Models;

namespace ControleFinanceiro.ViewModels;

public class DashboardViewModel
{
    public decimal TotalReceitas { get; set; }

    public decimal TotalDespesas { get; set; }

    public decimal Saldo => TotalReceitas - TotalDespesas;

    public int TotalTransacoes { get; set; }

    public List<Transacao> UltimasTransacoes { get; set; } = new();

    public Dictionary<string, decimal> GastosPorCategoria { get; set; } = new();

    public List<string> Categorias { get; set; } = new();

    public List<decimal> ValoresCategorias { get; set; } = new();

    public List<decimal> ReceitasMensais { get; set; } = new();

    public List<decimal> DespesasMensais { get; set; } = new();

    public List<string> Meses { get; set; } = new();
}