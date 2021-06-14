using System;
using System.ComponentModel.DataAnnotations;
using Core.Enums;

namespace Core.Models
{
    public class Payment : ModelBase
    {
        [Required]
        public PaymentTerm Term { get; set; }
        public DateTime? PaidAt { get; set; }
    }
}