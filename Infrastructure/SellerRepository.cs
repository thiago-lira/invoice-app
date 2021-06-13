using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure
{
    public class SellerRepository : RepositoryBase<Seller>, ISellerRepository
    {
        public SellerRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Seller GetSellerByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public async Task Save(Seller seller)
        {
            await DbSet.AddAsync(seller);
            await Context.SaveChangesAsync();
        }
    }
}
