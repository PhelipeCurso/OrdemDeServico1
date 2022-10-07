using Infraestrutura.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vvs.Infraestrutura.Data.EFCore;


namespace Infraestrutura.Data.Sessions
{
    public class OrdemDeServicoSession : EFCoreSession<OrdemDeServicoSession>
    {
        public  OrdemDeServicoSession(DbContextOptions<OrdemDeServicoSession>options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseNpgsql("Host=localhost;Database=OrdemDeServico;User Idpostgres;Password=masterkey;Enlist=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteDbMappings());
        }
    }
}
