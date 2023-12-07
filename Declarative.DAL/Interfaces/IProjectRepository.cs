namespace Declarative.DAL.Interfaces
{
    public interface IProjectRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetValue(int id);
        IEnumerable<T> Find(Func<T, bool> predicate);
        void Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}
