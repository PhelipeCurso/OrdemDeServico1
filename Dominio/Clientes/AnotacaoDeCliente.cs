using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vvs.Domain.Seedwork;

namespace Dominio.Clientes
{
   public class AnotacaoDeCliente : EntityBase
    {
        public DateTime Data { get; set; }
        public string Texto { get; set; }
        public Guid IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
