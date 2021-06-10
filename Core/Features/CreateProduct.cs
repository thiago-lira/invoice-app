namespace Core.Features
{
    public class CreateProduct
    {
        public string Name { get; }
        public double Price { get; }

        public CreateProduct(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
