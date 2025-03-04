using System.Text.Json;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonInvestmentRepository : IInvestmentRepository
    {
        private const string FilePath = "investments.json";
        private List<Investment> _investments;

        public JsonInvestmentRepository()
        {
            _investments = LoadInvestmentsFromFile();
        }

        public void AddInvestment(Investment investment)
        {
            _investments.Add(investment);
            SaveInvestmentsToFile();
        }

        public IEnumerable<Investment> GetAllInvestments() => _investments;

        public Investment GetInvestmentById(Guid id) => _investments.FirstOrDefault(i => i.Id == id);

        private List<Investment> LoadInvestmentsFromFile()
        {
            if (!File.Exists(FilePath))
                return new List<Investment>();

            var json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Investment>>(json) ?? new List<Investment>();
        }

        private void SaveInvestmentsToFile()
        {
            var json = JsonSerializer.Serialize(_investments, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }
    }
}