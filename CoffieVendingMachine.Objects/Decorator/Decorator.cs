using CoffeeVendingMachine.Core.Enums;
using CoffeeVendingMachine.Core.Models;
using CoffeeVendingMachine.Objects.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Objects.Decorator
{
    public abstract class Decorator : BaseCoffee
    {
        private BaseCoffee _coffee;

        public Decorator(BaseCoffee coffee)
        {
            _coffee = coffee;
        }

        public override string PrintConfiguration()
        {
            return _coffee.PrintConfiguration();
        }
    }
}
