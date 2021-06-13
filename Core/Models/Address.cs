using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Address : ModelBase
    {
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public string Country { get; set; }
    }
}