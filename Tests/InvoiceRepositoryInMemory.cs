using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task Save(Invoice invoice)
        {
            await Task.Delay(500);
            Invoices.Add(invoice);
        }
    }
}
