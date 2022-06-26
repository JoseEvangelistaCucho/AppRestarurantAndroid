using AppRestaurant.Models;
using AppRestaurant.Models.ModelService;

namespace AppRestaurant.Repository.Repository
{
    public interface IParametroRepository : IRepository<Parametro>
    {
        ResponseHeader GetByParametro(string id);
    }
}

