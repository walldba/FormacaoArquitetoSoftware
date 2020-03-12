using System;
using InjecaoDependencia.Cases;
using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependencia.Controllers
{
    public class MultiplasClassesController : Controller
    {
        private readonly Func<string, IService> _serviceAcessor;
        public MultiplasClassesController(Func<string, IService> serviceAcessor)
            => _serviceAcessor = serviceAcessor;

        public string Index()
            => _serviceAcessor("A").Retorno();
    }
}