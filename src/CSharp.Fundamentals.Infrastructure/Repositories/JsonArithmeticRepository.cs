using System.Text.Json;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonArithmeticRepository : IArithmeticRepository
    {
        private readonly string _filePath;
        private List<ArithmeticOperation> _operations;

        public JsonArithmeticRepository()
        {
            string solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName ?? "";

            string basePath = Path.Combine(solutionDirectory, "fundamentos-csharp\\src\\CSharp.Fundamentals.Infrastructure", "Data");
            _filePath = Path.Combine(basePath, "arithmetic_operations.json");

            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);


            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

            _operations = LoadFromFile();
        }

        public void Add(ArithmeticOperation operation)
        {
            _operations.Add(operation);
            SaveToFile();
        }

        public IEnumerable<ArithmeticOperation> GetAll() => _operations;

        public ArithmeticOperation? GetById(Guid id) => _operations.FirstOrDefault(o => o.Id == id);

        private List<ArithmeticOperation> LoadFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<ArithmeticOperation>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<ArithmeticOperation>>(json) ?? new List<ArithmeticOperation>();
        }

        private void SaveToFile()
        {
            var json = JsonSerializer.Serialize(_operations, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}