using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiShopBackend.Models
{
    public class DBShop:DbContext
    {
        
        public DBShop(DbContextOptions<DBShop> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Shop> Shop { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Counterparty> Counterparty { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DBShop;Trusted_Connection=True;");

        }
    }
}
