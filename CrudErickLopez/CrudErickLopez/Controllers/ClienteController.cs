using CrudErickLopez.Models;
using CrudErickLopez.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudErickLopez.Controllers
{
    [Route("/api/cliente")]
    [ApiController]
    public class ClienteController : Controller
    {
        private IClienteRepository clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        [Route("/Add")]
        [HttpPost]
        public async Task<Cliente> CreateCliente(Cliente cliente)
        {
            return await clienteRepository.CreateCliente(cliente);
        }

        [Route("/Edit/{id}")]
        [HttpPost]
        public async Task<Cliente?> UpdateCliente(int id, Cliente cliente)
        {
            return await clienteRepository.UpdateCliente(id, cliente);
        }

        [Route("/Delete/{id}")]
        [HttpDelete]
        public async Task DeleteCliente(int id)
        {
            await clienteRepository.DeleteCliente(id);
        }

        [Route("/")]
        [HttpGet]
        public async Task<List<Cliente>> GetAllCliente()
        {
            return await clienteRepository.GetAllCliente();
        }

        [Route("/{id}")]
        [HttpGet]
        public async Task<Cliente?> GetClienteById(int id)
        {
            return await clienteRepository.GetClienteById(id);
        }
    }
}
