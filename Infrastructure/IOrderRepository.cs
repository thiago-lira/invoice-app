using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure
{
    public interface IOrderRepository
    {
        public Task Save(Order order);
        public Order GetById(int id);
    }
}
