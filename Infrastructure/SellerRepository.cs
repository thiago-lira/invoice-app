using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class SellerRepository : RepositoryBase<Seller>, ISellerRepository
    {
        public SellerRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Seller> GetByIdAsync(int id)
        {
            return await DbSet
                .Where(s => s.Id == id)
                .Include(s => s.Address)
                .FirstOrDefaultAsync();
        }

        public async Task Save(Seller seller)
        {
            await DbSet.AddAsync(seller);
            await Context.SaveChangesAsync();
        }
    }
}
