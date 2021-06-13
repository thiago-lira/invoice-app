using System.Threading.Tasks;
using Core.Features;
using Services;
using Xunit;

namespace Tests
{
    public class CreateProductHandlerExecute
    {
        [Fact]
        public async Task GivenACreateProductCommandThenSaveIt()
        {
            var repository = new ProductRepositoryInMemory();
            var handler = new CreateProductHandler(repository);
            var command = new CreateProduct("My Product", 999.99);

            await handler.Execute(command);

            var productCreated = repository.GetByName("My Product");
            Assert.NotNull(productCreated);
        }
    }
}
