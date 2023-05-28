using MeuCrm.DTOs;
using MeuCrm.Models;

namespace MeuCrm.Repositories.IRepositories
{
    public interface IClienteRepository
    {
        PaginatedResponse<Cliente> GetClientes(int page, int pageSize);
    }
}
