namespace Core.Models
{
    public class OrderItem : ModelBase
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
    }
}