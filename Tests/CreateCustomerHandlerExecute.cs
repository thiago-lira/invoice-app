using System.Threading.Tasks;
using Core.Features;
using Core.Models;
using Services;
using Xunit;

namespace Tests
{
    public class CreateCustomerHandlerExecute
    {
        [Fact]
        public async Task GivenACreateCustomerCommandThenSaveIt()
        {
            var repository = new CustomerRepositoryInMemory();
            var handler = new CreateCustomerHandler(repository);
            var address = new Address();
            var command = new CreateCustomer("Fulano", "fulano@test.com", address);

            await handler.Execute(command);

            var customerSaved = await repository.GetByIdAsync(1);
            Assert.NotNull(customerSaved);
        }
    }
}
