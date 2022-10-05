using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Workflow.Models.Transitions
{
    public class TransitionChooseSugarMilk : StateTransition
    {
        public TransitionChooseSugarMilk(int currentState, Action<Process> action) : base(currentState, action)
        {
        }

        public override void Execute(Process process)
        {
            ToStateId = process.CurrentState;
            try
            {
                base.Execute(process);

                string input = process.ActionOutput.ToString();
                bool sugar = input.Split(';')[0].Equals("Y", StringComparison.OrdinalIgnoreCase);
                bool milk = input.Split(';')[1].Equals("Y", StringComparison.OrdinalIgnoreCase);

                process.Coffee.Milk = milk;
                process.Coffee.Sugar = sugar;

                ToStateId = 3;
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
