using CoffeeVendingMachine.Core.Enums;
using CoffeeVendingMachine.Objects.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Workflow.Models.Transitions
{
    public class TransitionChooseCoffeeType : StateTransition
    {
        private IBuilder _coffeeBuilder;
        public TransitionChooseCoffeeType(int currentState, Action<Process> action) : base(currentState, action)
        {
            _coffeeBuilder = new CustomCoffeeBuilder();
        }

        public override void Execute(Process process)
        {
            ToStateId = process.CurrentState;
            try
            {
                base.Execute(process);

                int input = int.Parse(process.ActionOutput.ToString());

                switch (input)
                {
                    case (int)CoffeeType.LATTE:
                    case (int)CoffeeType.MACCHIATO:
                    case (int)CoffeeType.ESPRESSO:
                    case (int)CoffeeType.AMERICANO:
                    case (int)CoffeeType.CAPPUCINO:
                        ToStateId = 2;
                        _coffeeBuilder.CreateCoffee((CoffeeType)input);
                        process.Coffee = _coffeeBuilder.GetCoffie();
                        break;
                    case 5:
                        ToStateId = 4;
                        break;
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                process.CurrentState = ToStateId;
            }
        }
    }
}
