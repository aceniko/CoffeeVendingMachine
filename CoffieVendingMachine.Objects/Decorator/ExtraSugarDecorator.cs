using CoffeeVendingMachine.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Objects.Decorator
{
    public class ExtraSugarDecorator : Decorator
    {
        public ExtraSugarDecorator(BaseCoffee coffee) : base(coffee)
        {
           HasExtraSugar = true;
        }

        public override string PrintConfiguration()
        {
            return base.PrintConfiguration() +
               $" Extra Sugar: {(HasExtraSugar ? "Yes" : "No")}"; ;
        }
    }
}
