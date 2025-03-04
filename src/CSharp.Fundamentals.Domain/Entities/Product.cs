namespace CSharp.Fundamentals.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(Guid id, string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("O nome do produto é obrigatório.", nameof(name));

            if (price <= 0)
                throw new ArgumentException("O preço deve ser maior que zero", nameof(price));

            Id = id;
            Name = name;
            Price = price;
        }

        public Product Update(string name, decimal price)
        {
            return new Product(Id, name, price);
        }
    }
}
