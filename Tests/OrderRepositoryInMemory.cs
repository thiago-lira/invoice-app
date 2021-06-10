using System.Collections.Generic;
using System.Linq;
using Core.Models;
using Infrastructure;

namespace Tests
{
    public class OrderRepositoryInMemory : IOrderRepository
    {
        private readonly List<Order> _orders = new();
        private static int _id { get; set; }

        public Order GetById(int id)
        {
            return _orders
                .Where(o => o.Id == id)
                .FirstOrDefault();
        }

        public void Save(Order order)
        {
            _id++;
            order.Id = _id;

            _orders.Add(order);
        }
    }
}
