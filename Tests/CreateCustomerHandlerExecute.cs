using Core.Features;
using Core.Models;
using Services;
using Xunit;

namespace Tests
{
    public class CreateCustomerHandlerExecute
    {
        [Fact]
        public void GivenACreateCustomerCommandThenSaveIt()
        {
            var repository = new CustomerRepositoryInMemory();
            var handler = new CreateCustomerHandler(repository);
            var address = new Address();
            var command = new CreateCustomer("Fulano", "fulano@test.com", address);

            handler.Execute(command);

            var customerSaved = repository.GetCustomerByName("Fulano");
            Assert.NotNull(customerSaved);
        }
    }
}
