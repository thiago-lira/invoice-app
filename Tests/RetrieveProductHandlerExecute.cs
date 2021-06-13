using System.Threading.Tasks;
using Core.Features;
using Services;
using Xunit;

namespace Tests
{
    public class RetrieveProductHandlerExecute
    {
        [Fact]
        public async Task GivenARetrieveProductCommandThenRetrieveAProduct()
        {
            var repository = new ProductRepositoryInMemory();
            var retrieveProductHandler = new RetrieveProductHandler(repository);
            var createProductHandler = new CreateProductHandler(repository);
            var createProduct = new CreateProduct("Teste", 12.12);

            await createProductHandler.Execute(createProduct);

            var command = new RetrieveProduct(1);

            var product = await retrieveProductHandler.Execute(command);
            Assert.NotNull(product);
        }
    }
}
