using System.Collections.Generic;
using Core.Models;

namespace Core.Features
{
    public class CreateOrder
    {
        public Customer Customer { get; }
        public Seller Seller { get; }
        public List<Product> Products { get; }
        public Payment Payment { get; }

        public CreateOrder(Customer customer, Seller seller, List<Product> products, Payment payment)
        {
            Customer = customer;
            Seller = seller;
            Products = products;
            Payment = payment;
        }
    }
}
