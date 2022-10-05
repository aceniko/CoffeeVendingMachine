using CoffeeVendingMachine.Core.Enums;
using CoffeeVendingMachine.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Objects.Builder
{
    public abstract class CoffeeBuilder : IBuilder
    {
        protected BaseCoffee _coffie;

        public abstract void CreateCoffee(CoffeeType coffieType);
        public BaseCoffee GetCoffie()
        {
            return _coffie;
        }

        public void Reset()
        {
            _coffie = null;
        }
    }
}
