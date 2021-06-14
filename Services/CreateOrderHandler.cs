using System.Threading.Tasks;
using Core.Enums;
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

        public async Task Execute(CreateOrder createOrder)
        {
            createOrder.Payment.Term = PaymentTerm.ONE_MONTH;

            var order = new Order()
            {
                Customer = createOrder.Customer,
                Products = createOrder.Products,
                Payment = createOrder.Payment
            };

            await _repository.Save(order);
        }
    }
}
