using System.Threading.Tasks;
using Core.Features;
using Core.Models;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services;

namespace API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class SellersController : ControllerBase
    {
        private readonly ISellerRepository _repository;

        public SellersController(ISellerRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Seller seller)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var handler = new CreateSellerHandler(_repository);
                var command = new CreateSeller(seller.Name, seller.Email, seller.Address);

                await handler.Execute(command);

                return NoContent();
            }
            catch (DbUpdateException)
            {
                return StatusCode(500);
            }
        }
    }
}
