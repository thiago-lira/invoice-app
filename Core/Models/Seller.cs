namespace Core.Models
{
    public class Seller : ModelBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}
