using System.Collections.Generic;
using Core.Features;
using Core.Models;
using Services;
using Xunit;

namespace Tests
{
    public class CreateOrderHandlerExecute
    {
        [Fact]
        public void GivenACreateOrderCommandThenSaveIt()
        {
            var repository = new OrderRepositoryInMemory();
            var handler = new CreateOrderHandler(repository);
            var customer = new Customer();
            var products = new List<Product>();
            var payment = new Payment();
            var command = new CreateOrder(customer, products, payment);

            handler.Execute(command);

            var createdOrder = repository.GetById(1);
            Assert.NotNull(createdOrder);
        }
    }
}
