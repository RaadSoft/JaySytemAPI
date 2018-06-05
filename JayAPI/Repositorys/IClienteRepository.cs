using System.Collections.Generic;
using JayAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace JayAPI.Repositorys
{
    public interface IClienteRepository
    {
        List<Cliente> ListarClientes();
        List<Cliente> ListarClientes(int qtde);
        void salvar(Cliente cliente);
    }
}