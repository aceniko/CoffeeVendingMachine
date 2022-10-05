using CoffeeVendingMachine.Core.Models;
using CoffeeVendingMachine.Objects.Builder;

namespace CoffeeVendingMachine.Objects.Test
{
    [TestFixture(
        Description = "A collection of tests for the Coffee vending machine objects.",
        TestOf = typeof(CustomCoffeeBuilder),
        Author = "Aleksandar")]
    public class Tests
    {
        [TestFixture()]
        public class EspressoCoffeeCreate {
            private IBuilder _builder;
            [SetUp]
            public void Setup() {
                _builder = new CustomCoffeeBuilder();
            }

            [Test]
            public void IsEspressoCoffeeType() {
                _builder.CreateCoffee(Core.Enums.CoffeeType.ESPRESSO);
                Assert.IsAssignableFrom<EspressoCoffee>(_builder.GetCoffie());
            }

            [Test]
            public void IsNotEspressoCoffeeType()
            {
                _builder.CreateCoffee(Core.Enums.CoffeeType.AMERICANO);
                Assert.IsNotAssignableFrom<EspressoCoffee>(_builder.GetCoffie());
            }
        }
    }
}