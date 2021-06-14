using System;
using System.ComponentModel.DataAnnotations;
using Core.Enums;

namespace Core.Models
{
    public class Invoice : ModelBase
    {
        [Required]
        public Seller Seller { get; set; }
        [Required]
        public Order Order { get; set; }
        [Required]
        public InvoiceStatus Status { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public ValidationInfo ValidationInfo { get; set; }
    }
}
