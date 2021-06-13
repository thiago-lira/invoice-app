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

        public Customer GetCustomerByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task Save(Customer customer)
        {
            await DbSet.AddAsync(customer);
            await Context.SaveChangesAsync();
        }
    }
}
