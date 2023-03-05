using System.Collections.Generic;
using ByteBankMvc.Models;

namespace ByteBankMvc.Repositorio {
    public interface IContasRepositorio {

        ContasModel ListPorId (int id);
        List<ContasModel> BuscarTodos();
        ContasModel Adicionar (ContasModel contas);
        ContasModel Atualizar(ContasModel contas);
        bool Apagar (int id);

    }
}
