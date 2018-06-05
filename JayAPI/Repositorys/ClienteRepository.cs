using JayAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace JayAPI.Repositorys
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly JayContexto _jayContexto;
        public ClienteRepository(JayContexto jayContexto)
        {
            _jayContexto = jayContexto;
        }

        public List<Cliente> ListarClientes()
        {
            
            List <Cliente> l =_jayContexto.Clientes
                    .Include(p => p.endereco)
                    .Include(p => p.enderecoCobranca)
                    .Include(p => p.enderecoEntrega)
                    .ToList();
            return l;
        }

        public List<Cliente> ListarClientes(int qtde)
        {
            return _jayContexto.Clientes.Include(p => p.endereco)
                    .Include(p => p.enderecoCobranca)
                    .Include(p => p.enderecoEntrega)
                    .Take(qtde)
                    .ToList();
        }

        public void salvar(Cliente cliente)
        {
            _jayContexto.Clientes.Add(cliente);
            _jayContexto.SaveChanges();
        }
    }
}
