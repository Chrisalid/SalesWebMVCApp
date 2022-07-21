using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMVCApp.Models;

namespace SalesWebMVCApp.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCAppContext _context;

        public DepartmentService(SalesWebMVCAppContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}