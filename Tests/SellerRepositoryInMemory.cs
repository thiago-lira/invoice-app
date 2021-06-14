using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Infrastructure;

namespace Tests
{
    public class SellerRepositoryInMemory : ISellerRepository
    {
        private readonly List<Seller> _sellers = new();

        public async Task<Seller> GetByIdAsync(int id)
        {
            await Task.Delay(500);

            return _sellers
                .Where(s => s.Id == id)
                .FirstOrDefault();
        }

        public async Task Save(Seller seller)
        {
            await Task.Delay(500);
            _sellers.Add(seller);
        }
    }
}
