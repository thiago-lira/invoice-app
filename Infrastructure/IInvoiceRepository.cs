using Core.Models;

namespace Infrastructure
{
    public interface IInvoiceRepository
    {
        public void Save(Invoice invoice);
    }
}
