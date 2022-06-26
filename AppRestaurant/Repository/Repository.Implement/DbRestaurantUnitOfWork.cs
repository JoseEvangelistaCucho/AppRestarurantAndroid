namespace AppRestaurant.Repository.Repository.Implement
{
    public class DbRestaurantUnitOfWork : IUnitOfWork
    {
        public DbRestaurantUnitOfWork(string connectionString)
        {
            Clientes = new ClienteRepository(connectionString);
        }

        public IClienteRepository Clientes { get; private set; }
    }
}
