﻿using Core.Enums;
using Core.Features;
using Core.Models;
using Services;
using Xunit;

namespace Tests
{
    public class CreateInvoiceHandlerExecute
    {
        private readonly CreateInvoice CreateInvoice;
        private readonly CreateInvoiceHandler Handler;
        private readonly InvoiceRepositoryInMemory Repository;
        private readonly Order Order;

        public CreateInvoiceHandlerExecute()
        {
            var seller = new Seller();
            var customer = new Customer();
            var payment = new Payment();

            Order = new Order()
            {
                Customer = customer
            };

            Repository = new InvoiceRepositoryInMemory();
            Handler = new CreateInvoiceHandler(Repository);
            CreateInvoice = new CreateInvoice(customer, seller, payment, Order);
        }
        [Fact]
        public void GivenACreateInvoiceCommandThenSaveAInvoice()
        {
            Handler.Execute(CreateInvoice);

            var createdInvoice = Repository.GetByOrder(Order);
            Assert.NotNull(createdInvoice);
        }

        [Fact]
        public void GivenACreateInvoiceCommandThenCreatedInvoiceHasStatusPending()
        {
            Handler.Execute(CreateInvoice);

            var createdInvoice = Repository.GetByOrder(Order);
            Assert.Equal(InvoiceStatus.PENDING, createdInvoice.Status);
        }
    }
}
