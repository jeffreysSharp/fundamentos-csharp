using System.Text.Json;
using CSharp.Fundamentals.Domain.Repositories;
using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonControlStructureRepository : JsonRepository<ControlStructure>, IControlStructureRepository
    {
        public JsonControlStructureRepository() : base("control-structure") { }

        public ControlStructure? GetById(Guid id)
        {
            return GetAll().FirstOrDefault(data => data.Id == id);
        }

        public void Delete(Guid id)
        {
            var entities = GetAll().ToList();
            var entityToRemove = entities.FirstOrDefault(e => e.Id == id);
            if (entityToRemove != null)
            {
                entities.Remove(entityToRemove);
                SaveToFile();
            }
        }
    }
}