using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVCApp.Models;

namespace SalesWebMVCApp.Data
{
    public class SalesWebMVCAppContext : DbContext
    {
        public SalesWebMVCAppContext (DbContextOptions<SalesWebMVCAppContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMVCApp.Models.Department> Department { get; set; }
    }
}
