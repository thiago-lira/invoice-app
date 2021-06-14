using System;
using Core.Enums;

namespace Core.Models
{
    public class Payment : ModelBase
    {
        public PaymentTerm Term { get; set; }
        public DateTime PaidAt { get; set; }
    }
}