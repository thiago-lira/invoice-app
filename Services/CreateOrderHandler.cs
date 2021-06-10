using System;
using Core.Features;
using Core.Models;
using Infrastructure;

namespace Services
{
    public class CreateOrderHandler
    {
        private readonly IOrderRepository _repository;

        public CreateOrderHandler(IOrderRepository repository)
        {
            _repository = repository;
        }

        public void Execute(CreateOrder createOrder)
        {
            var order = new Order()
            {
                Customer = createOrder.Customer,
                Products = createOrder.Products,
                Payment = createOrder.Payment
            };

            _repository.Save(order);
        }
    }
}
