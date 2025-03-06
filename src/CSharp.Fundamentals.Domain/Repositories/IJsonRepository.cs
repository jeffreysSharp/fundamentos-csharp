namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface IJsonRepository<T> where T : class
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
        T? GetById(Func<T, bool> predicate);
    }
}
