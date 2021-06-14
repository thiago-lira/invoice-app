using System.Collections.Generic;
using Core.Enums;
using Core.Features;
using Core.Models;
using Services;
using Xunit;

namespace Tests
{
    public class CreateOrderHandlerExecute
    {
        private readonly OrderRepositoryInMemory _repository;
        private readonly CreateOrderHandler _createOrderHandler;
        private readonly Customer _customer;
        private readonly Seller _seller;
        private readonly List<Product> _products;
        private readonly Payment _payment;
        private readonly CreateOrder _command;

        public CreateOrderHandlerExecute()
        {
            _repository = new OrderRepositoryInMemory();
            _createOrderHandler = new CreateOrderHandler(_repository);
            _customer = new Customer();
            _products = new List<Product>();
            _payment = new Payment();
            _command = new CreateOrder(_customer, _seller, _products, _payment);
        }
        [Fact]
        public void GivenACreateOrderCommandThenSaveIt()
        {
            _createOrderHandler.Execute(_command);

            var createdOrder = _repository.GetById(1);
            Assert.NotNull(createdOrder);
        }

        [Fact]
        public void GivenACreateOrderCommandThenCreateAnInvoiceWithPaymentTermAsOneMonth()
        {
            _createOrderHandler.Execute(_command);

            var createdOrder = _repository.GetById(1);
            Assert.Equal(PaymentTerm.ONE_MONTH, createdOrder.Payment.Term);
        }
    }
}
