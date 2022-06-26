namespace AppRestaurant.Repository.Repository.Implement
{
    public class DbRestaurantUnitOfWork : IUnitOfWork
    {
        public DbRestaurantUnitOfWork(string connectionString)
        {
            Clientes = new ClienteRepository(connectionString);
            Parametros = new ParametroRepository(connectionString);
        }

        public IClienteRepository Clientes { get; private set; }
        public IParametroRepository Parametros { get; private set; }
    }
}
