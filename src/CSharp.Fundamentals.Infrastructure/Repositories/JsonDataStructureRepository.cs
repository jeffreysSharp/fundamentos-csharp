using System.Text.Json;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{

    public class JsonDataStructureRepository : JsonRepository<Investor>, IDataStructureRepository
    {
        public JsonDataStructureRepository() : base("investor") { }

        public void Clear()
        {
            _entities.Clear();
            SaveToFile();
        }

        public Investor? GetById(Guid id)
        {
            return GetById(item => item.Id == id);
        }

        public void SaveAll(IEnumerable<Investor> investors)
        {
            Clear();
            foreach (var investor in investors)
            {
                Add(investor);
            }
        }
    }
}