using System.Text.Json;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonLogicalOperationRepository : ILogicalRepository
    {
        private readonly string _filePath;
        private List<LogicalOperation> _operations;

        public JsonLogicalOperationRepository()
        {
            string solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName ?? "";
            string basePath = Path.Combine(solutionDirectory, "fundamentos-csharp\\src\\CSharp.Fundamentals.Infrastructure", "Data");
            _filePath = Path.Combine(basePath, "logical_operation.json");

            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

            _operations = LoadFromFile();
        }

        public void Add(LogicalOperation operation)
        {
            _operations.Add(operation);
            SaveToFile();
        }

        public IEnumerable<LogicalOperation> GetAll() => _operations;

        public LogicalOperation? GetById(Guid id) => _operations.FirstOrDefault(o => o.Id == id);

        private List<LogicalOperation> LoadFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<LogicalOperation>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<LogicalOperation>>(json) ?? new List<LogicalOperation>();
        }

        private void SaveToFile()
        {
            var json = JsonSerializer.Serialize(_operations, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}
