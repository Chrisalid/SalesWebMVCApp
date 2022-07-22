using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obg => obg.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }

}