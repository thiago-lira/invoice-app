using Core.Models;

namespace Core.Features
{
    public class CreateInvoice
    {
        public Customer Customer { get; }
        public Seller Seller { get; }
        public Order Order { get; }

        public CreateInvoice(Customer customer, Seller seller, Order order)
        {
            Customer = customer;
            Seller = seller;
            Order = order;
        }
    }
}
