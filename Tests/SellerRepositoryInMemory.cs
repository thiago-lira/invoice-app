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

        public Seller GetSellerByName(string name)
        {
            return _sellers
                .Where(s => s.Name == name)
                .FirstOrDefault();
        }

        public async Task Save(Seller seller)
        {
            await Task.Delay(500);
            _sellers.Add(seller);
        }
    }
}
