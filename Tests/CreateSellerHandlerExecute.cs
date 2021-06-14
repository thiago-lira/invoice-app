using System.Threading.Tasks;
using Core.Features;
using Core.Models;
using Services;
using Xunit;

namespace Tests
{
    public class CreateSellerHandlerExecute
    {
        [Fact]
        public async Task GivenAnCreateSellerCommandThenSaveIt()
        {
            var repository = new SellerRepositoryInMemory();
            var handler = new CreateSellerHandler(repository);
            var command = new CreateSeller("Beltrano", "beltrano@test.com", new Address());

            await handler.Execute(command);

            var sellerCreated = repository.GetByIdAsync(1);
            Assert.NotNull(sellerCreated);
        }
    }
}
