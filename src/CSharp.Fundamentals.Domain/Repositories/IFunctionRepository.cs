using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface IFunctionRepository
    {
        void Add(Function function);
        IEnumerable<Function> GetAll();
    }
}
