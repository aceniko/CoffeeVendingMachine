using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.DataAccess
{
    internal class DbContextSeeder
    {
        public static void Seed(CoffeeContext context)
        {

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.Coffee.Add(new Entity.CoffeeEntity
            {
                Name = "Doppio"
            });

            context.Coffee.Add(new Entity.CoffeeEntity
            {
                Name = "Cortado"
            });

            context.Coffee.Add(new Entity.CoffeeEntity
            {
                Name = "Red Eye"
            });

            context.Coffee.Add(new Entity.CoffeeEntity
            {
                Name = "Ristretto"
            });

            context.Coffee.Add(new Entity.CoffeeEntity
            {
                Name = "Lungo"
            });

            context.SaveChanges();
        }
    }
}
