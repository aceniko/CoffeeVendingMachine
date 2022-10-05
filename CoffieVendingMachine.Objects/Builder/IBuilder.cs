using CoffeeVendingMachine.Core.Enums;
using CoffeeVendingMachine.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Objects.Builder
{
    public interface IBuilder
    {
        void CreateCoffee(CoffeeType coffieType);

        BaseCoffee GetCoffie();

        void Reset();
    }
}
