﻿using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(Guid productId);
        void UpdateProduct(Product product);
        void DeleteProduct(Guid productId);
    }
}
