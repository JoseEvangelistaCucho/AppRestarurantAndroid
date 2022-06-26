namespace AppRestaurant.Repository.Repository.Implement
{
    public interface IUnitOfWork
    {
        IClienteRepository Clientes { get; }
        IParametroRepository Parametros { get; }
    }
}
