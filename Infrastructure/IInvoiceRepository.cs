using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure
{
    public interface IInvoiceRepository
    {
        Task Save(Invoice invoice);
    }
}
