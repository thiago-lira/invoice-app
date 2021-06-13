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
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _repository;

        public CustomersController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var handler = new CreateCustomerHandler(_repository);
                var command = new CreateCustomer(customer.Name, customer.Email, customer.Address);
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
