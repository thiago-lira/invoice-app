using Core.Models;

namespace Core.Features
{
    public class CreateSeller
    {
        public string Name { get; }
        public string Email { get; }
        public Address Address { get; }

        public CreateSeller(string name, string email, Address address)
        {
            Name = name;
            Email = email;
            Address = address;
        }
    }
}
