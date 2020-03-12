using InjecaoDependencia.Cases;
using InversaoDependencia.Models;
using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependencia.Controllers
{
    public class GenericController : Controller
    {
        private readonly IGenericRepository<Cliente> _clienteRepository;

        public GenericController(IGenericRepository<Cliente> clienteRepository)
           => _clienteRepository = clienteRepository;

        public void Index()
            => _clienteRepository.Adicionar(new Cliente());
    }
}