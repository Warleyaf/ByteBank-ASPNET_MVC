using Microsoft.AspNetCore.Mvc;

namespace ByteBankMvc.Controllers {
    public class TransacaoController : Controller {
        public IActionResult Index () {
            return View();
        }

        public IActionResult Deposito () {
            return View();
        }

        public IActionResult Transferir () {
            return View();
        }

        public IActionResult Saque () {
            return View();
        }
    }
}
