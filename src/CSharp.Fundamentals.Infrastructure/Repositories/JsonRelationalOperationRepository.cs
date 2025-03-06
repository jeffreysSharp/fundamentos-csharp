using System.Text.Json;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonRelationalOperationRepository : IRelationalRepository
    {
        private readonly string _filePath;
        private List<RelationalOperation> _operations;

        public JsonRelationalOperationRepository()
        {
            string solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName ?? "";

            string basePath = Path.Combine(solutionDirectory, "fundamentos-csharp\\src\\CSharp.Fundamentals.Infrastructure", "Data");
            _filePath = Path.Combine(basePath, "relational_operation.json");

            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

            _operations = LoadFromFile();
        }

        public void Add(RelationalOperation operation)
        {
            _operations.Add(operation);
            SaveToFile();
        }

        public IEnumerable<RelationalOperation> GetAll() => _operations;

        public RelationalOperation? GetById(Guid id) => _operations.FirstOrDefault(o => o.Id == id);

        private List<RelationalOperation> LoadFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<RelationalOperation>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<RelationalOperation>>(json) ?? new List<RelationalOperation>();
        }

        private void SaveToFile()
        {
            var json = JsonSerializer.Serialize(_operations, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}