using System;
using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Product GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Save(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
