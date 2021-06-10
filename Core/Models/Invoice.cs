using System;

namespace Core.Models
{
    public class Invoice
    {
        // TODO: Change to Enum
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public Seller Seller { get; set; }
        public Order Order { get; set; }
    }
}
