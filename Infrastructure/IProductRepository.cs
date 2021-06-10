using Core.Models;

namespace Infrastructure
{
    public interface IProductRepository
    {
        public void Save(Product product);
        public Product GetByName(string name);
    }
}
