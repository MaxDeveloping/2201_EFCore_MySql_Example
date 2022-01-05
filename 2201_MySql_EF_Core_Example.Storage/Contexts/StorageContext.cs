using _2201_MySql_EF_Core_Example.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2201_MySql_EF_Core_Example.Storage.Contexts
{
    public class StorageContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public StorageContext(DbContextOptions pOptions) : base(pOptions)
        {
        }
    }
}
