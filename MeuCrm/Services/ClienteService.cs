using MeuCrm.DTOs;
using MeuCrm.Models;
using MeuCrm.Repositories.IRepositories;
using MeuCrm.Services.IServices;

namespace MeuCrm.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public PaginatedResponse<Cliente> GetClientes(int page, int pageSize)
        {
            return _clienteRepository.GetClientes(page, pageSize);
        }
    }
}
