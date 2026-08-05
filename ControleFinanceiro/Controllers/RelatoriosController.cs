using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class RelatoriosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}