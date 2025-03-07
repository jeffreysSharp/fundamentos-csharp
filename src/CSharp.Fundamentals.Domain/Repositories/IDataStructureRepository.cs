namespace CSharp.Fundamentals.Domain.Repositories
{
    using CSharp.Fundamentals.Domain.Entities;

    public interface IDataStructureRepository
    {
        void Add(Investor investor);
        void SaveAll(IEnumerable<Investor> investors);
        IEnumerable<Investor> GetAll();
        Investor? GetById(Guid id);
        void Clear();
    }
}