using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vvs.Domain.Seedwork;

namespace Dominio.Clientes
{
    public class EnderecoDoCliente : EntityBase
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string NumeroLogradouro { get; set; }
        public string ComplementoLogradouro { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
        public Guid IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }

    }
}
