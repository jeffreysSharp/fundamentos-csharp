using System.Text.Json;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonInvestmentRepository : IInvestmentRepository
    {
        private readonly string _filePath;
        private List<Investment> _investments;

        public JsonInvestmentRepository()
        {
            string solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName ?? "";

            string basePath = Path.Combine(solutionDirectory, "fundamentos-csharp\\src\\CSharp.Fundamentals.Infrastructure", "Data");
            _filePath = Path.Combine(basePath, "investment.json");

            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

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
            if (!File.Exists(_filePath))
                return new List<Investment>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Investment>>(json) ?? new List<Investment>();
        }

        private void SaveInvestmentsToFile()
        {
            var json = JsonSerializer.Serialize(_investments, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}