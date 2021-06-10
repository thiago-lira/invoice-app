using System.Collections.Generic;
using Core.Models;

namespace Core.Features
{
    public class CreateInvoice
    {
        public Customer Customer { get; }
        public Seller Seller { get; }
        public Payment Payment { get; }
        public List<InvoiceItem> Items { get; }

        public CreateInvoice(Customer customer, Seller seller, Payment payment, List<InvoiceItem> items)
        {
            Customer = customer;
            Seller = seller;
            Payment = payment;
            Items = items;
        }
    }
}
