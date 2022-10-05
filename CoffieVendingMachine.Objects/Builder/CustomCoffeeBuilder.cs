using CoffeeVendingMachine.Core.Enums;
using CoffeeVendingMachine.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Objects.Builder
{
    public class CustomCoffeeBuilder : CoffeeBuilder
    {
        public override void CreateCoffee(CoffeeType coffieType)
        {
            switch (coffieType) {
                case CoffeeType.CAPPUCINO:
                    _coffie = new CappucinoCoffee();
                    break;
                case CoffeeType.ESPRESSO:
                    _coffie = new EspressoCoffee();
                    break;
                case CoffeeType.AMERICANO:
                    _coffie = new AmericanoCoffee();
                    break;
                case CoffeeType.MACCHIATO:
                    _coffie = new MacchiatoCoffee();
                    break;
                case CoffeeType.LATTE:
                    _coffie = new LatteCoffee();
                    break;
                default: _coffie = new ExternalCoffee(); break;
            }
        }
    }
}
