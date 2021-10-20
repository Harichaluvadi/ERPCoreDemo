using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERPCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace ERPCoreDemo.Data
{
    public class ERPContext:DbContext
    {
        public ERPContext(DbContextOptions<ERPContext> options):base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
