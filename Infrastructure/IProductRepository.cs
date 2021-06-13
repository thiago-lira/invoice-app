using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure
{
    public interface IProductRepository
    {
        public Task Save(Product product);
        public Product GetByName(string name);
    }
}
