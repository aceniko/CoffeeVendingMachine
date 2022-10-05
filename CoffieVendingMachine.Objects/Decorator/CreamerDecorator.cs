using CoffeeVendingMachine.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Objects.Decorator
{
    public class CreamerDecorator : Decorator
    {
        public CreamerDecorator(BaseCoffee coffee) : base(coffee)
        {
            HasCream = true;
        }

        public override string PrintConfiguration()
        {
            return base.PrintConfiguration() +
               $" Cream: {(HasCream ? "Yes" : "No")}";
             
        }
    }
}
