namespace ASP_Lez05_task_Nasa.Repositories
{
    public interface IRepo<T>
    {
        IEnumerable<T> GetAll();
        T? Get(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}
