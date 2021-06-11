using System;
using Core.Enums;

namespace Core.Models
{
    public class Invoice
    {
        public InvoiceStatus Status { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public Seller Seller { get; set; }
        public Order Order { get; set; }
    }
}
