using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.Sessions
{
    public class OrdemDeServicoSessionFactory : IDesignTimeDbContextFactory<OrdemDeServicoSession>
    {
        public OrdemDeServicoSession CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OrdemDeServicoSession>();
            return new OrdemDeServicoSession(optionsBuilder.Options);
        }
    }
}
