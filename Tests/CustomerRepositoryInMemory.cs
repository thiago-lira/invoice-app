using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Infrastructure;

namespace Tests
{
    internal class CustomerRepositoryInMemory : ICustomerRepository
    {
        private readonly List<Customer> _customers = new();
        private int _id { get; set; }

        public CustomerRepositoryInMemory()
        {
            _id = 1;
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            await Task.Delay(500);

            return _customers
                .Where(c => c.Id == id)
                .FirstOrDefault();
        }

        public async Task SaveAsync(Customer customer)
        {
            customer.Id = _id++;
            await Task.Delay(500);

            _customers.Add(customer);
        }
    }
}