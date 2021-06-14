using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure
{
    public interface ICustomerRepository
    {
        Task SaveAsync(Customer customer);
        Task<Customer> GetByIdAsync(int id);
    }
}
