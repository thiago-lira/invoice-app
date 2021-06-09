using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class Invoice
    {
        public string Name { get; set; }
        public double Total { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public Customer Customer { get; set; }
        public Seller Seller { get; set; }
        public List<InvoiceItem> Items { get; set; }
        public Payment Payment { get; set; }
    }
}
