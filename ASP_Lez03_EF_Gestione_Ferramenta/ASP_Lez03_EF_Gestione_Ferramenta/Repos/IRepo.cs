namespace ASP_Lez03_EF_Gestione_Ferramenta.Repos
{
    public interface IRepo<T>
    {
        IEnumerable<T> GetAll();
        T? Get(int id);
        bool Create(T t);
        bool Insert(T t);
        bool Update(T t);
        bool Delete(int id);
    }
}
