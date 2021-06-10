using System;
using Core.Features;
using Core.Models;
using Infrastructure;

namespace Services
{
    public class CreateInvoiceHandler
    {
        private readonly IInvoiceRepository _repository;

        public CreateInvoiceHandler(IInvoiceRepository repository)
        {
            _repository = repository;
        }

        public void Execute(CreateInvoice createInvoice)
        {
            var invoice = new Invoice
            {
                Seller = createInvoice.Seller,
                Customer = createInvoice.Customer,
                Payment = createInvoice.Payment,
                Items = createInvoice.Items,
                CreatedAt = DateTime.UtcNow
            };

            _repository.Save(invoice);
        }
    }
}
