using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Infrastructure;

namespace Tests
{
    public class OrderRepositoryInMemory : IOrderRepository
    {
        private readonly List<Order> _orders = new();
        private static int _id { get; set; }

        public OrderRepositoryInMemory()
        {
            _id = 1;
        }

        public async Task<Order> GetById(int id)
        {
            await Task.Delay(500);

            return _orders
                .Where(o => o.Id == id)
                .FirstOrDefault();
        }

        public async Task Save(Order order)
        {
            order.Id = _id++;

            await Task.Delay(500);

            _orders.Add(order);
        }
    }
}
