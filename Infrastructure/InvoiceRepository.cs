using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure
{
    public class InvoiceRepository : RepositoryBase<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task Save(Invoice invoice)
        {
            await DbSet.AddAsync(invoice);
            await Context.SaveChangesAsync();
        }
    }
}
