using ByteBankMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace ByteBankMvc.Data {
    public class BancoContext : DbContext //Herdando o contexto do EntityFramwork dentro do banco de dados
    { // Fzendo Configuração padrão do nosso contexto do banco
        // ai em baixo vou estar fazendo o construtor

        // E nesse construtor é um injeção de dependecia
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) {  // injetando como parametro de entrada o DBContextOptions, e dentro dele iremos tipar ele como BancoContext
                                                         // Passando as informaçoes do options do construtor padrão que é o DbContext, utilizando o base
            
        }

        public DbSet<ContasModel> Contas { get; set; }

    }
}
