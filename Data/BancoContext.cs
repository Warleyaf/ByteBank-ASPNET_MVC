using ByteBankMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace ByteBankMvc.Data {
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) {
            
        }

        public DbSet<ContasModel> Contas { get; set; }

    }
}
