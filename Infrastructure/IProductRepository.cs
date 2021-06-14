using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure
{
    public interface IProductRepository
    {
        public Task Save(Product product);
        public Product GetByName(string name);
        public Task<Product> GetById(int id);
        Task<List<Product>> GetListByIdsAsync(int[] ids);
    }
}
