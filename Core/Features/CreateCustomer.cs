using System;
using Core.Models;

namespace Core.Features
{
    public class CreateCustomer
    {
        public string Name { get; }
        public string Email { get; }
        public Address Address { get; }

        public CreateCustomer(string name, string email, Address address)
        {
            Name = name;
            Email = email;
            Address = address;
        }
    }
}
