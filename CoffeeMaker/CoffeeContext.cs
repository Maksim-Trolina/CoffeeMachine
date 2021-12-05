using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoffeeMaker
{
    public class CoffeeContext : DbContext
    {
        public DbSet<OperationCoffee> CoffeeOperations { get; set; } = null!;

        public CoffeeContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=users1db;Username=postgres;Password=Your_password");
        }
    }
}
