using fruit.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace fruit.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Categories> category { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Inventory> inventories { get; set; }
        public DbSet<contact> Contacts { get; set; }
        public DbSet<Accounts> accounts { get; set; }
        public DbSet<Orders> order { get; set; }

    }
}
