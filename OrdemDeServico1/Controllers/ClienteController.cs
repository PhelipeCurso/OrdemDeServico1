using Aplicacao.Clientes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdemDeServico1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
      

        private readonly ILogger<ClienteController> _logger;
        private ClienteAppService _clienteAppService;
        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
            _clienteAppService = new ClienteAppService(); 
        }

        [HttpGet]
        public IEnumerable<ClienteDto> Get()
        {
            return _clienteAppService.Pesquisar();
        }

        [HttpPost]
        [Route("incluir")]
        public IActionResult IncluirCliente ([FromBody]ClienteDto cliente)
        {
            if (cliente.Codigo < 10)
                return Ok("Cliente foi gravado com sucesso.");
            else
                return BadRequest("Cliente não foi  gravado com sucesso ");
            
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult ExcluirCliente(int id)
        {
            return Ok($"Cliente com id {id} foi excluido com sucesso.");

        }
    }
}
