using ByteBankMvc.Models;
using ByteBankMvc.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ByteBankMvc.Controllers {
    public class ListarContasController : Controller {

        private readonly IContasRepositorio _contasRepositorio;
        public ListarContasController (IContasRepositorio contasRepositorio) {
            _contasRepositorio = contasRepositorio;
        }

        public IActionResult Index () {
           List<ContasModel> contas = _contasRepositorio.BuscarTodos();
            return View(contas);
        }

        public IActionResult Criar () {
            return View();
        }

        public IActionResult Editar (int id) {
            ContasModel conta =  _contasRepositorio.ListPorId(id);
            return View(conta);
        }

        public IActionResult ApagarConfirmacao (int id) {
            ContasModel conta = _contasRepositorio.ListPorId(id);
            return View(conta);
        }




        public IActionResult Apagar(int id) {
            _contasRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Criar (ContasModel conta) {
            _contasRepositorio.Adicionar(conta);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar (ContasModel conta) {
            _contasRepositorio.Atualizar(conta);
            return RedirectToAction("Index");
        }

    }
}
