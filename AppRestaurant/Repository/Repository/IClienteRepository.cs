using AppRestaurant.Models;
using AppRestaurant.Models.ModelService;

namespace AppRestaurant.Repository.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        ResponseHeader GetByDocumento(string nroDocumento, string password);
        ResponseHeader CreateUserCliente(Cliente cliente);
    }
}
