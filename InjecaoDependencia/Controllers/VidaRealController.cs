using InversaoDependencia.Interfaces;
using InversaoDependencia.Models;
using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependencia.Controllers
{
    public class VidaRealController : Controller
    {
        private readonly IClienteService _clienteServices;

        public VidaRealController(IClienteService clienteServices)
        => _clienteServices = clienteServices;

        public void Index()
        => _clienteServices.AdicionarCliente(new Cliente());
    }
}