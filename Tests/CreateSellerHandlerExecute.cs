using Core.Features;
using Core.Models;
using Services;
using Xunit;

namespace Tests
{
    public class CreateSellerHandlerExecute
    {
        [Fact]
        public void GivenAnCreateSellerCommandThenSaveIt()
        {
            var repository = new SellerRepositoryInMemory();
            var handler = new CreateSellerHandler(repository);
            var command = new CreateSeller("Beltrano", "beltrano@test.com", new Address());

            handler.Execute(command);

            var sellerCreated = repository.GetSellerByName("Beltrano");
            Assert.NotNull(sellerCreated);
        }
    }
}
