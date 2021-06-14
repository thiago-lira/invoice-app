using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Order GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task Save(Order order)
        {
            await DbSet.AddAsync(order);
            await Context.SaveChangesAsync();
        }
    }
}
