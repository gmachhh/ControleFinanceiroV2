using ControleFinanceiro.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.Controllers;

public class HomeController : Controller
{
    private readonly IDashboardService _dashboardService;

    public HomeController(IDashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    public async Task<IActionResult> Index()
    {
        var model = await _dashboardService.ObterDashboardAsync();

        return View(model);
    }
}