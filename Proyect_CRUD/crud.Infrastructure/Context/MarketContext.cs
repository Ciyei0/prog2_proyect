using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace market.Infrastructure.Context
{
    internal class MarketContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("YourConnectionStringHere");
        }
    }
}
