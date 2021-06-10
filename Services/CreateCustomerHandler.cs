using Core.Features;
using Core.Models;
using Infrastructure;

namespace Services
{
    public class CreateCustomerHandler
    {
        private readonly ICustomerRepository _repository;

        public CreateCustomerHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public void Execute(CreateCustomer createCustomer)
        {
            var customer = new Customer()
            {
                Name = createCustomer.Name,
                Email = createCustomer.Email,
                Address = createCustomer.Address
            };

            _repository.Save(customer);
        }
    }
}
