using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class ConfiguracoesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}