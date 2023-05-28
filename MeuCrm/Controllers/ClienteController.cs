using MeuCrm.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeuCrm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService) 
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        [Route("/clientes")]
        public ActionResult GetAllClientes(int page, int pageSize)
        {
            try
            {
                var clientes = _clienteService.GetClientes(page, pageSize);
                return Ok(clientes);
            } catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
    }
}
