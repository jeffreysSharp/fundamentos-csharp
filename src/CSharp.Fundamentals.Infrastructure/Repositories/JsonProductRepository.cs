using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;
using System.Text.Json;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonProductRepository : IProductRepository
    {
        private const string FilePath = "products.json";
        private List<Product> _products;

        public JsonProductRepository()
        {
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
            if (!File.Exists(FilePath))
                return new List<Product>();

            var json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
        }

        private void SaveProductsToFile()
        {
            var json = JsonSerializer.Serialize(_products, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }
    }
}
