using CoffeeVendingMachine.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Objects.Decorator
{
    public class CaramelleDecorator : Decorator
    {
        public CaramelleDecorator(BaseCoffee coffee) : base(coffee)
        {
            HasCaramelle = true;
        }

        public override string PrintConfiguration()
        {
            return base.PrintConfiguration() +
               $" Caramelle: {(HasCaramelle ? "Yes" : "No")}";
        }
    }
}
