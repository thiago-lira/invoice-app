using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Product : ModelBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
    }
}