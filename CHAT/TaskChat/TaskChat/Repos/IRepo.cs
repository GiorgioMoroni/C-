namespace TaskChat.Repos
{
    public interface IRepo<T>
    {
        IEnumerable<T> GetAll();
        T? Get(int id);
        bool Insert(T t);
        bool Update(T t);
        bool Delete(int id);
    }
}
