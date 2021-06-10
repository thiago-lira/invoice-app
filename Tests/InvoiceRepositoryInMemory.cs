using System.Collections.Generic;
using Core.Models;
using Infrastructure;

namespace Tests
{
    public class InvoiceRepositoryInMemory : IInvoiceRepository
    {
        private readonly List<Invoice> Invoices = new();

        // TODO: Refactor to GetInvoiceByOrder()
        public List<Invoice> GetInvoices()
        {
            return Invoices;
        }

        public void Save(Invoice invoice)
        {
            Invoices.Add(invoice);
        }
    }
}
