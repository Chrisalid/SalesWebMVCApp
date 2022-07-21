using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVCApp.Models;

namespace SalesWebMVCApp.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCAppContext _context;

        public SellerService(SalesWebMVCAppContext context)
        {
            _context = context;
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }

}