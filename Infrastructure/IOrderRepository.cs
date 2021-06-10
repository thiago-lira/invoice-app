using Core.Models;

namespace Infrastructure
{
    public interface IOrderRepository
    {
        public void Save(Order order);
        public Order GetById(int id);
    }
}
