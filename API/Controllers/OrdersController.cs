using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTOs;
using Core.Features;
using Core.Models;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly ISellerRepository _sellerRepository;
        private readonly IProductRepository _productRepository;

        public OrdersController(
            IOrderRepository orderRepository,
            ICustomerRepository customerRepository,
            ISellerRepository sellerRepository,
            IProductRepository productRepository
        )
        {
            _orderRepository = orderRepository;
            _customerRepository = customerRepository;
            _sellerRepository = sellerRepository;
            _productRepository = productRepository;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] OrderDTO orderDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var customer = await _customerRepository.GetByIdAsync(orderDTO.CustomerId);
            if (customer == null)
            {
                return BadRequest();
            }

            var seller = await _sellerRepository.GetByIdAsync(orderDTO.SellerId);
            if (seller == null)
            {
                return BadRequest();
            }

            var products = await GetProductsByIdsAsync(orderDTO.ProductsId);
            if (products.Count != orderDTO.ProductsId.Length)
            {
                return BadRequest();
            }

            var handler = new CreateOrderHandler(_orderRepository);
            var command = new CreateOrder(customer, seller, products, orderDTO.Payment);
            await handler.Execute(command);

            return NoContent();
        }

        private async Task<List<Product>> GetProductsByIdsAsync(int[] ids)
        {
            return await _productRepository.GetListByIdsAsync(ids);
        }
    }
}
