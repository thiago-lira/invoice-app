using Core.Models;

namespace Infrastructure
{
    public interface ISellerRepository
    {
        public void Save(Seller seller);
        public Seller GetSellerByName(string name);
    }
}
