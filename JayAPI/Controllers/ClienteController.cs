using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JayAPI.Models;
using JayAPI.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace JayAPI.Controllers
{
    [Route("api/[Controller]")]
    public class ClienteController : Controller
    {

        private readonly IClienteRepository _cliente;
        public ClienteController(IClienteRepository cliente)
        {
            this._cliente = cliente;
        }

        [HttpGet]
        public IActionResult get()
        {
            try
            {
                return Ok(_cliente.ListarClientes());
            }
            catch (Exception err)
            {
                return BadRequest("Erro: " + err.Message);
            }

        }
        [HttpGet("{qtde:int}") ]
        public IActionResult get(int qtde)
        {
            try
            {
                return Ok(_cliente.ListarClientes(qtde));
            }
            catch (Exception err)
            {
                return BadRequest("Erro: " + err.Message);
            }

        }

        [HttpPost]
        public IActionResult Post([FromBody]Cliente cliente)
        {
            try
            {
                _cliente.salvar(cliente);
                return Created("/api/Cliente",cliente);
            }
            catch (Exception err)
            {

                return BadRequest("Não foi possivel Salvar erro: " + err.Message);
            }
        }
    }
}