using System;

namespace Core.Models
{
    public class Payment : ModelBase
    {
        public string Term { get; set; }
        public DateTime PaidAt { get; set; }
    }
}