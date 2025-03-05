using System.Text.Json;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonNumericDataRepository : INumericDataRepository
    {
        private const string FilePath = "numeric_data.json";
        private List<NumericDataExample> _dataList;

        public JsonNumericDataRepository()
        {
            _dataList = LoadFromFile();
        }

        public void Add(NumericDataExample data)
        {
            _dataList.Add(data);
            SaveToFile();
        }

        public IEnumerable<NumericDataExample> GetAll() => _dataList;

        public NumericDataExample? GetById(Guid id) => _dataList.FirstOrDefault(d => d.Id == id);

        private List<NumericDataExample> LoadFromFile()
        {
            if (!File.Exists(FilePath))
                return new List<NumericDataExample>();

            var json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<NumericDataExample>>(json) ?? new List<NumericDataExample>();
        }

        private void SaveToFile()
        {
            var json = JsonSerializer.Serialize(_dataList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }
    }
}