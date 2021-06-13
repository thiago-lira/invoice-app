using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure
{
    public interface ISellerRepository
    {
        Task Save(Seller seller);
        Seller GetSellerByName(string name);
    }
}
