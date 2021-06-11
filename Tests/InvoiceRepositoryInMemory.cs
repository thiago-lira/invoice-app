using System.Collections.Generic;
using System.Linq;
using Core.Models;
using Infrastructure;

namespace Tests
{
    public class InvoiceRepositoryInMemory : IInvoiceRepository
    {
        private readonly List<Invoice> Invoices = new();

        public Invoice GetByOrder(Order order)
        {
            return Invoices
                .Where(o => o.Order == order)
                .FirstOrDefault();
        }

        public void Save(Invoice invoice)
        {
            Invoices.Add(invoice);
        }
    }
}
