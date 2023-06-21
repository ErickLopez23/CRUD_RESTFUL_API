using CrudErickLopez.Models;

namespace CrudErickLopez.Repository
{
    public interface IClienteRepository
    {
        Task<Cliente> CreateCliente(Cliente cliente);
        Task<Cliente?> UpdateCliente(int id, Cliente cliente);
        Task DeleteCliente(int id);
        Task<List<Cliente>> GetAllCliente();
        Task<Cliente?> GetClienteById(int id);
    }
}
