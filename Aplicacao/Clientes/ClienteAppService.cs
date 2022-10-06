using OrdemDeServico1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Clientes
{
    public class ClienteAppService
    {
        public void Incluir(ClienteDto cliente)
        {

        }
        public void Excluir(int id)
        {

        }
        public void Alterar(ClienteDto cliente)
        {

        }
        public List<ClienteDto> Pesquisar()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new ClienteDto
            {
                Codigo = rng.Next(1, 55),
                Nome = $"Cliente {rng.Next(1, 55)}"
            })
            .ToList();
        }
    }
}
