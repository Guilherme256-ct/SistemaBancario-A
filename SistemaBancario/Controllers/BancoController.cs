using Microsoft.AspNetCore.Mvc;

namespace SistemaBancario.Controllers
{
    public class BancoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
