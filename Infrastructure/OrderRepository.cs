using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Order> GetById(int id)
        {
            return await DbSet
                .Where(o => o.Id == id)
                .Include(o => o.Customer)
                .ThenInclude(c => c.Address)
                .Include(o => o.Seller)
                .ThenInclude(s => s.Address)
                .Include(o => o.Payment)
                .Include(o => o.Products)
                .FirstOrDefaultAsync();
        }

        public async Task Save(Order order)
        {
            await DbSet.AddAsync(order);
            await Context.SaveChangesAsync();
        }
    }
}
