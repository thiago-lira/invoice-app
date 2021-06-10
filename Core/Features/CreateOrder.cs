using System.Collections.Generic;
using Core.Models;

namespace Core.Features
{
    public class CreateOrder
    {
        public Customer Customer { get; }
        public List<Product> Products { get; }
        public Payment Payment { get; }

        public CreateOrder(Customer customer, List<Product> products, Payment payment)
        {
            Customer = customer;
            Products = products;
            Payment = payment;
        }
    }
}
