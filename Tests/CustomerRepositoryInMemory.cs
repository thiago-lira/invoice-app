using System.Collections.Generic;
using System.Linq;
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

        public void Save(Customer customer)
        {
            _customers.Add(customer);
        }
    }
}