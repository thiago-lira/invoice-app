using System.Threading.Tasks;
using Core.DTOs;
using Core.Features;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services;

namespace API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IOrderRepository _orderRepository;

        public InvoicesController(IInvoiceRepository invoiceRepository, IOrderRepository orderRepository)
        {
            _invoiceRepository = invoiceRepository;
            _orderRepository = orderRepository;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] InvoiceDTO invoiceDTO)
        {
            var order = await _orderRepository.GetById(invoiceDTO.OrderId);

            if (order == null)
            {
                return BadRequest();
            }

            try
            {
                var handler = new CreateInvoiceHandler(_invoiceRepository);
                var command = new CreateInvoice(order);

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
