using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure
{
    public interface ICustomerRepository
    {
        Task Save(Customer customer);
        Customer GetCustomerByName(string name);
    }
}
