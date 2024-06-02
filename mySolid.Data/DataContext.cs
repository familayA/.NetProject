using Microsoft.EntityFrameworkCore;
using mySolid.Core.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySolid.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Customer> CustomersList { get; set; }
        public DbSet<Order> OrdersList { get; set; }

        public DbSet<Product> ProductsList { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=my_db1");
        }
    }
}




