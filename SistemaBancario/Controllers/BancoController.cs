using Microsoft.AspNetCore.Mvc;

namespace SistemaBancario.Controllers
{
    public class BancoController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string tipoAcesso,string senha,string numeroConta)
        {
            return View();
        }
        [HttpGet]
        public ActionResult MinhaConta(string numero)
        {
            return View();
        }
        [HttpPost]
        public ActionResult RealizarTransacao(string numeroConta, string tipoAcao, decimal valor) {
            return View();
        }
        public ActionResult PainelGerente()
        {
            return View();
        }
            
    }
}
