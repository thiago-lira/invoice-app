using System;
using System.Collections.Generic;
using System.Linq;
using Core.Models;
using Infrastructure;

namespace Tests
{
    public class SellerRepositoryInMemory : ISellerRepository
    {
        private readonly List<Seller> _sellers = new();

        public Seller GetSellerByName(string name)
        {
            return _sellers
                .Where(s => s.Name == name)
                .FirstOrDefault();
        }

        public void Save(Seller seller)
        {
            _sellers.Add(seller);
        }
    }
}
