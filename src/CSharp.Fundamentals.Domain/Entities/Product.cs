namespace CSharp.Fundamentals.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, decimal price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
        }

        public void Update(string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("O nome do produto é obrigatório.", nameof(name));

            if (price <= 0)
                throw new ArgumentException("O preço deve ser maior que 0.", nameof(price));

            Name = name;
            Price = price;
        }
    }
}
