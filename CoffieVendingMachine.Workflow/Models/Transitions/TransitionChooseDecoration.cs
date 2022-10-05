using CoffeeVendingMachine.Objects.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Workflow.Models.Transitions
{
    public class TransitionChooseDecoration : StateTransition
    {
        public TransitionChooseDecoration(int currentState, Action<Process> action) : base(currentState, action)
        {
        }

        public override void Execute(Process process)
        {
            ToStateId = process.CurrentState;
            try
            {
                base.Execute(process);

                int decoration = int.Parse(process.ActionOutput.ToString());

                switch (decoration)
                {
                    case 1:
                        process.Coffee = new CaramelleDecorator(process.Coffee);
                        break;
                    case 2:
                        process.Coffee = new CreamerDecorator(process.Coffee);
                        break;
                    case 3:
                        process.Coffee = new ExtraMilkDecorator(process.Coffee);
                        break;
                    case 4:
                        process.Coffee = new ExtraSugarDecorator(process.Coffee);
                        break;
                    default: throw new Exception("Invalid decoration");
                }

                ToStateId = 5;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally {
                process.CurrentState = ToStateId;
            }
        }
    }
}
