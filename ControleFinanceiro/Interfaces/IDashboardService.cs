using ControleFinanceiro.ViewModels;

namespace ControleFinanceiro.Interfaces;

public interface IDashboardService
{
    Task<DashboardViewModel> ObterDashboardAsync();
}