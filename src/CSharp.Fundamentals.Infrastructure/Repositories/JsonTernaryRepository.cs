using System.Text.Json;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonTernaryRepository : ITernaryRepository
    {
        private readonly string _filePath;
        private List<TernaryOperation> _operations;

        public JsonTernaryRepository()
        {
            string solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName ?? "";
            string basePath = Path.Combine(solutionDirectory, "fundamentos-csharp\\src\\CSharp.Fundamentals.Infrastructure", "Data");
            _filePath = Path.Combine(basePath, "ternary_operations.json");

            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

            _operations = LoadFromFile();
        }

        public void Add(TernaryOperation operation)
        {
            _operations.Add(operation);
            SaveToFile();
        }

        public IEnumerable<TernaryOperation> GetAll() => _operations;

        public TernaryOperation? GetById(Guid id) => _operations.FirstOrDefault(o => o.Id == id);

        private List<TernaryOperation> LoadFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<TernaryOperation>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<TernaryOperation>>(json) ?? new List<TernaryOperation>();
        }

        private void SaveToFile()
        {
            var json = JsonSerializer.Serialize(_operations, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}
