using System;
using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<Customer> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync(Customer customer)
        {
            await DbSet.AddAsync(customer);
            await Context.SaveChangesAsync();
        }
    }
}
