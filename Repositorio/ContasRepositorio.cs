using ByteBankMvc.Data;
using ByteBankMvc.Models;

namespace ByteBankMvc.Repositorio {
    public class ContasRepositorio : IContasRepositorio {

        private readonly BancoContext _context;

        public ContasRepositorio (BancoContext bancoContext) { // injetando o BancoContext
            this._context = bancoContext;
        }

        public List<ContasModel> BuscarTodos () {
           return _context.Contas.ToList();
        }

        public ContasModel ListPorId (int id) => _context.Contas.FirstOrDefault(x => x.Id == id);

        public ContasModel Adicionar (ContasModel contas) {
            // Gravar no banco de dados
            _context.Contas.Add (contas);
            _context.SaveChanges();
            return contas;
        }

        public ContasModel Atualizar (ContasModel contas) {
            ContasModel contaDB = ListPorId(contas.Id);

            if (contaDB == null) throw new Exception("Houve um erro ao alterar o usuário");

            contaDB.Cpf = contas.Cpf;
            contaDB.Titular = contas.Titular;
            contaDB.Senha = contas.Senha;

            _context.Contas.Update(contaDB);
            _context.SaveChanges();
            return contaDB;
        }

        public bool Apagar (int id) {
            ContasModel contaDB = ListPorId(id);

            if (contaDB == null) throw new Exception("Houve um erro ao deletar o usuário");

            _context.Contas.Remove(contaDB);
            _context.SaveChanges();

            return true;
        }
    }
}
