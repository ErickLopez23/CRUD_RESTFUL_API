using CrudErickLopez.Models;

namespace CrudErickLopez.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private ApiCrudContext db;

        public ClienteRepository(ApiCrudContext db)
        {
            this.db = db;
        }

        public async Task<Cliente> CreateCliente(Cliente cliente)
        {
            try
            {
                db.Clientes.Add(cliente);
                await db.SaveChangesAsync();
                return cliente;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteCliente(int id)
        {
            try
            {
                var cliente = db.Clientes.FirstOrDefault(c => c.Id == id);
                if (cliente == null)
                {
                    return;
                }

                db.Clientes.Remove(cliente);
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Cliente>> GetAllCliente()
        {
            try
            {
                var data = new List<Cliente>();
                await Task.Run(() => data = db.Clientes.ToList());
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Cliente?> GetClienteById(int id)
        {
            try
            {
                return await db.Clientes.FindAsync(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Cliente?> UpdateCliente(int id, Cliente cliente)
        {
            try
            {
                var obj = await db.Clientes.FindAsync(id);
                if (obj != null)
                {
                    obj.Direccion = cliente.Direccion;
                    obj.Email = cliente.Email;
                    obj.Fecha_nacimiento = cliente.Fecha_nacimiento;
                    obj.Direccion = cliente.Direccion;
                    obj.Nombres = cliente.Nombres;
                    obj.Apellidos = cliente.Apellidos;


                    await db.SaveChangesAsync();
                }
                return obj;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
