using System.Text.Json;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonNumericDataRepository : INumericDataRepository
    {
        private readonly string _filePath;
        private List<NumericData> _dataList;

        public JsonNumericDataRepository()
        {
            string solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName ?? "";

            string basePath = Path.Combine(solutionDirectory, "fundamentos-csharp\\src\\CSharp.Fundamentals.Infrastructure", "Data");
            _filePath = Path.Combine(basePath, "numeric_data.json");

            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

            _dataList = LoadFromFile();
        }

        public void Add(NumericData data)
        {
            _dataList.Add(data);
            SaveToFile();
        }

        public IEnumerable<NumericData> GetAll() => _dataList;

        public NumericData? GetById(Guid id) => _dataList.FirstOrDefault(d => d.Id == id);

        private List<NumericData> LoadFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<NumericData>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<NumericData>>(json) ?? new List<NumericData>();
        }

        private void SaveToFile()
        {
            var json = JsonSerializer.Serialize(_dataList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}