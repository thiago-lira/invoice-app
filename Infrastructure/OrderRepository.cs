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
                .FirstOrDefaultAsync();
        }

        public async Task Save(Order order)
        {
            await DbSet.AddAsync(order);
            await Context.SaveChangesAsync();
        }
    }
}
