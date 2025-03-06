using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface IFunctionRepository : IJsonRepository<Function>
    {
        void Add(Function function);
        IEnumerable<Function> GetAll();
        Function? GetById(Guid id);
    }
}
