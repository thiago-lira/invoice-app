using Core.Models;

namespace Core.Features
{
    public class CreateInvoice
    {
        public Customer Customer { get; }
        public Seller Seller { get; }
        public Order Order { get; }

        public CreateInvoice(Order order)
        {
            Customer = order.Customer;
            Seller = order.Seller;
            Order = order;
        }
    }
}
