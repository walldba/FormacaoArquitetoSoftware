using InversaoDependencia.Interfaces;
using InversaoDependencia.Models;

namespace InversaoDependencia
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClienteService(IClienteRepository clienteRepository, IEmailServices emailServices)
        {
            _clienteRepository = clienteRepository;
            _emailServices = emailServices;
        }
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);
            _emailServices.Enviar("empresa@empresa.com", cliente.Email, "assunto", "mensagem");

            return "Cliente Cadastrado com sucesso!";  
        }
    }
}