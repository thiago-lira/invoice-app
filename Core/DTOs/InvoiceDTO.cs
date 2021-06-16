namespace Core.DTOs
{
    public class InvoiceDTO
    {
        public int OrderId { get; set; }

        public InvoiceDTO(int orderId)
        {
            OrderId = orderId;
        }
    }
}
