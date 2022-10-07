using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vvs.Domain.Seedwork;

namespace Dominio.Clientes
{
    public class Cliente :EntityBase
    {
        public string Nome { get; set; }
        public string CnpjCpf { get; set; }
        public DateTime? DateDeNascimento {get;set;}
        public string CelularPrincipal { get; set; }
        public string EmailPrincipal { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<AnotacaoDeCliente> Anotacoes { get; set; }
        public virtual IEnumerable<EnderecoDoCliente> Enderecos { get; set; }

    }
}
