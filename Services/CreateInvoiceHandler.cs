﻿using System;
using Core.Enums;
using Core.Features;
using Core.Models;
using Infrastructure;

namespace Services
{
    public class CreateInvoiceHandler
    {
        private readonly IInvoiceRepository _repository;

        public CreateInvoiceHandler(IInvoiceRepository repository)
        {
            _repository = repository;
        }

        public void Execute(CreateInvoice createInvoice)
        {
            var invoice = new Invoice
            {
                Status = InvoiceStatus.PENDING,
                Seller = createInvoice.Seller,
                Order = createInvoice.Order,
                CreatedAt = DateTime.UtcNow
            };

            _repository.Save(invoice);
        }
    }
}
