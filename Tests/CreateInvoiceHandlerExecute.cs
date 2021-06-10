using System.Collections.Generic;
using System.Linq;
using Core.Features;
using Core.Models;
using Services;
using Xunit;

namespace Tests
{
    public class CreateInvoiceHandlerExecute
    {
        [Fact]
        public void GivenACreateInvoiceCommandThenSaveAInvoice()
        {
            var repository = new InvoiceRepositoryInMemory();
            var handler = new CreateInvoiceHandler(repository);
            var seller = new Seller();
            var customer = new Customer();
            var payment = new Payment();
            var items = new List<InvoiceItem>();
            var createInvoice = new CreateInvoice(customer, seller, payment, items);

            handler.Execute(createInvoice);

            var savedInvoice = repository.GetInvoices().Where(i => i.Customer == customer);
            Assert.NotNull(savedInvoice);
        }
    }
}
