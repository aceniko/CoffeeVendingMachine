using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Core.Models
{
    public abstract class BaseCoffee
    {
        public bool Sugar { get; set; } = false;
        public bool Milk { get; set; } = false;
        public bool HasCaramelle { get; set; } = false;
        public bool HasCream { get; set; } = false;
        public bool HasExtraMilk { get; set; } = false;
        public bool HasExtraSugar { get; set; } = false;
        public string Name { get;  set; }

        public BaseCoffee() { }

        public BaseCoffee(string name) { 
            Name = name;
        }

        public virtual string PrintConfiguration() {
            return $"Name: {Name}, Sugar:  {(Sugar ? "Yes" : "No")}, Milk: {(Milk ? "Yes" : "No")}";

        }

    }
}
