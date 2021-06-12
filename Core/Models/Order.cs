using System.Collections.Generic;

namespace Core.Models
{
    public class Order : ModelBase
    {
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public double Price { get; set; }
        public Payment Payment { get; set; }
    }
}