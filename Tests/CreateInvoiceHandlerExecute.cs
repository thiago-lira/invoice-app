using System.Threading.Tasks;
using Core.Enums;
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

            Order = new Order()
            {
                Seller = seller,
                Customer = customer
            };

            Repository = new InvoiceRepositoryInMemory();
            Handler = new CreateInvoiceHandler(Repository);
            CreateInvoice = new CreateInvoice(Order);
        }

        [Fact]
        public async Task GivenACreateInvoiceCommandThenSaveAInvoice()
        {
            await Handler.Execute(CreateInvoice);

            var createdInvoice = Repository.GetByOrder(Order);
            Assert.NotNull(createdInvoice);
        }

        [Fact]
        public async Task GivenACreateInvoiceCommandThenCreatedInvoiceHasStatusPending()
        {
            await Handler.Execute(CreateInvoice);

            var createdInvoice = Repository.GetByOrder(Order);
            Assert.Equal(InvoiceStatus.PENDING, createdInvoice.Status);
        }
    }
}
