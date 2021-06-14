using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<Product>> GetListByIdsAsync(int[] ids)
        {
            return await DbSet
                .Where(p => ids.Contains(p.Id))
                .ToListAsync<Product>();
        }

        public async Task Save(Product product)
        {
            await DbSet.AddAsync(product);
            await Context.SaveChangesAsync();
        }
    }
}
