using CoffeeVendingMachine.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace CoffeeVendingMachine.DataAccess
{
    public class CoffeeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(@"DataSource=database.db;");
        }

        public DbSet<CoffeeEntity> Coffee { get; set; }
    }
}