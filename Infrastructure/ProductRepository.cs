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

        public async Task<Product> GetById(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public Product GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task Save(Product product)
        {
            await DbSet.AddAsync(product);
            await Context.SaveChangesAsync();
        }
    }
}
