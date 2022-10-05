using CoffeeVendingMachine.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Objects.Decorator
{
    public class ExtraMilkDecorator : Decorator
    {
        public ExtraMilkDecorator(BaseCoffee coffee) : base(coffee)
        {
            HasExtraMilk = true;
        }

      public override string PrintConfiguration()
      {
            return base.PrintConfiguration() +
               $" Extra Milk: {(HasExtraMilk ? "Yes" : "No")}";
             
        }
    }
}
