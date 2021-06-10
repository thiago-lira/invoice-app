using System.Collections.Generic;
using Core.Models;

namespace Core.Features
{
    public class CreateInvoice
    {
        public Customer Customer { get; }
        public Seller Seller { get; }
        public Payment Payment { get; }
        public Order Order { get; }

        public CreateInvoice(Customer customer, Seller seller, Payment payment, Order order)
        {
            Customer = customer;
            Seller = seller;
            Payment = payment;
            Order = order;
        }
    }
}
