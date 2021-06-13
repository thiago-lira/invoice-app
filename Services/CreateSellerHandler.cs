using System.Threading.Tasks;
using Core.Features;
using Core.Models;
using Infrastructure;

namespace Services
{
    public class CreateSellerHandler
    {
        private readonly ISellerRepository _repository;

        public CreateSellerHandler(ISellerRepository repository)
        {
            _repository = repository;
        }

        public async Task Execute(CreateSeller createSeller)
        {
            var seller = new Seller()
            {
                Name = createSeller.Name,
                Email = createSeller.Email,
                Address = createSeller.Address
            };

            await _repository.Save(seller);
        }
    }
}
