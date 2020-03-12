using InversaoDependencia.Interfaces;
using InversaoDependencia.Models;
using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependencia.Controllers
{
    public class FromServicesController : Controller
    {
        public void Index([FromServices] IClienteService clienteServices)
            => clienteServices.AdicionarCliente(new Cliente());
    }
}