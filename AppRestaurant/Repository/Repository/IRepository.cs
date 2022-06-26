namespace AppRestaurant.Repository.Repository
{
    public interface IRepository<T> where T : class
    {
        int Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        IEnumerable<T> GetList();
        T GetById(int id);
        T GetById(string id);
    }
}
