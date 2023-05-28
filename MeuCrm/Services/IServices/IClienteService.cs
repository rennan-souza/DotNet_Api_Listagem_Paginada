using MeuCrm.DTOs;
using MeuCrm.Models;

namespace MeuCrm.Services.IServices
{
    public interface IClienteService
    {
        PaginatedResponse<Cliente> GetClientes(int page, int pageSize);
    }
}
