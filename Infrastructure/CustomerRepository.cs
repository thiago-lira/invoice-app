using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await DbSet
                .Where(c => c.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task SaveAsync(Customer customer)
        {
            await DbSet.AddAsync(customer);
            await Context.SaveChangesAsync();
        }
    }
}
