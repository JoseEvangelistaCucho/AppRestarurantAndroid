using AppRestaurant.Models.ModelService;

namespace AppRestaurant.Repository.Repository.Implement
{
    public class ParametroRepository : Repository<Parametro>, IParametroRepository
    {
        public ParametroRepository(string connectionString) : base(connectionString)
        {
        }
    }
}
