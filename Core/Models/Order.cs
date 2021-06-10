using System.Collections.Generic;

namespace Core.Models
{
    public class Order
    {
        public List<OrderItem> Products { get; set; }
        public double Price { get; set; }
        public Payment Payment { get; set; }
    }
}