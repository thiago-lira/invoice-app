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

        public Customer GetCustomerByName(string name)
        {
            return _customers
                .Where(c => c.Name == name)
                .FirstOrDefault();
        }

        public async Task Save(Customer customer)
        {
            await Task.Delay(500);
            _customers.Add(customer);
        }
    }
}