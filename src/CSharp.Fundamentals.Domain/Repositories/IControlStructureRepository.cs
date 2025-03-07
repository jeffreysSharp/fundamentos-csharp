using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface IControlStructureRepository : IJsonRepository<ControlStructure>
    {
        void Add(ControlStructure controlStructure);
        IEnumerable<ControlStructure> GetAll();
        ControlStructure? GetById(Guid id);
        void Delete(Guid id);
    }
}