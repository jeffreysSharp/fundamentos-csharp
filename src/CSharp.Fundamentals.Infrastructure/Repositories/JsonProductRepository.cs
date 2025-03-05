using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;
using System.Text.Json;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonProductRepository : IProductRepository
    {
        private readonly string _filePath;
        private List<Product> _products;

        public JsonProductRepository()
        {
            string solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName ?? "";

            string basePath = Path.Combine(solutionDirectory, "fundamentos-csharp\\src\\CSharp.Fundamentals.Infrastructure", "Data");
            _filePath = Path.Combine(basePath, "products.json");

            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

            _products = LoadProductsFromFile();
        }

        public void CreateProduct(Product product)
        {
            _products.Add(product);
            SaveProductsToFile();
        }

        public IEnumerable<Product> GetAllProducts() => _products;

        public Product GetProductById(Guid productId) => _products.FirstOrDefault(p => p.Id == productId);

        public void UpdateProduct(Product product)
        {
            var index = _products.FindIndex(p => p.Id == product.Id);
            if (index != -1)
            {
                _products[index] = product;
                SaveProductsToFile();
            }
        }

        public void DeleteProduct(Guid productId)
        {
            _products.RemoveAll(p => p.Id == productId);
            SaveProductsToFile();
        }

        private List<Product> LoadProductsFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<Product>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
        }

        private void SaveProductsToFile()
        {
            var json = JsonSerializer.Serialize(_products, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}
