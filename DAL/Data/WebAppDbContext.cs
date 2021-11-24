using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DAL.Data
{
    public class WebAppDbContext : DbContext
    {
        public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options)
        {

        }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<CustOrderHistory> CustOrderHistory { get; set; }

    }
}
