using System.Text.Json;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonRepository<T> : IJsonRepository<T> where T : class
    {
        private readonly string _filePath;
        private List<T> _entities;

        public JsonRepository(string fileName)
        {
            string solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName ?? "";
            string basePath = Path.Combine(solutionDirectory, "fundamentos-csharp\\src\\CSharp.Fundamentals.Infrastructure", "Data");
            _filePath = Path.Combine(basePath, fileName);

            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

            _entities = LoadFromFile();
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
            SaveToFile();
        }

        public IEnumerable<T> GetAll() => _entities;

        public T? GetById(Func<T, bool> predicate) => _entities.FirstOrDefault(predicate);

        private List<T> LoadFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<T>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        private void SaveToFile()
        {
            var json = JsonSerializer.Serialize(_entities, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}
