using System;
using System.Threading.Tasks;
using Core.Features;
using Core.Models;
using Infrastructure;

namespace Services
{
    public class RetrieveProductHandler
    {
        private readonly IProductRepository _productRepository;

        public RetrieveProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Execute(RetrieveProduct retrieveProduct)
        {
            return await _productRepository.GetById(retrieveProduct.Id);
        }
    }
}
