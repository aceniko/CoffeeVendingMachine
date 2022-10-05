using CoffeeVendingMachine.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.DataAccess.Manager
{
    public class DataManager : IDataManager
    {
        public DataManager() {
            var context = new CoffeeContext();
            DbContextSeeder.Seed(context);
        }
        public IEnumerable<CoffeeEntity> GetCoffees()
        {
            using (var db = new CoffeeContext()) {
                return db.Coffee.ToList();
            }
        }
    }
}
