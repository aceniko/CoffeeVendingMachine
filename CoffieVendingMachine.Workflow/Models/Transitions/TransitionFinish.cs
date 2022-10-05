using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Workflow.Models.Transitions
{
    public class TransitionFinish : StateTransition
    {
        public TransitionFinish(int currentState, Action<Process> action) : base(currentState, action)
        {
        }

        public override void Execute(Process process)
        {
            base.Execute(process);
            process.CurrentState = 6;
        }
    }
}
