using Core.Models;

namespace Infrastructure
{
    public interface ICustomerRepository
    {
        public void Save(Customer customer);
        public Customer GetCustomerByName(string name);
    }
}
