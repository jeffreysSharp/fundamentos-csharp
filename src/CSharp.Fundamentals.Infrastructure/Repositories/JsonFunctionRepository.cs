using System.Text.Json;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonFunctionRepository : IFunctionRepository
    {
        private readonly string _filePath;
        private List<Function> _functions;

        public JsonFunctionRepository()
        {
            string solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName ?? "";
            string basePath = Path.Combine(solutionDirectory, "fundamentals-csharp\\src\\CSharp.Fundamentals.Infrastructure", "Data");
            _filePath = Path.Combine(basePath, "functions.json");

            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

            _functions = LoadFromFile();
        }

        public void Add(Function function)
        {
            _functions.Add(function);
            SaveToFile();
        }

        public IEnumerable<Function> GetAll() => _functions;

        private List<Function> LoadFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<Function>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Function>>(json) ?? new List<Function>();
        }

        private void SaveToFile()
        {
            var json = JsonSerializer.Serialize(_functions, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}
