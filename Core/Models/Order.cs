using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Order : ModelBase
    {
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public Seller Seller { get; set; }
        [Required]
        public List<Product> Products { get; set; }
        [Required]
        public Payment Payment { get; set; }
        public double Price { get; set; }
    }
}