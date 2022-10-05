using CoffeeVendingMachine.Workflow.Models;
using CoffeeVendingMachine.Workflow.Models.Transitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Workflow
{
    public interface IWorkflow
    {
        void OnInit(Process process);

        void ExecuteFlow(State currentState, Process process);

        void ExecuteTransition(State currentState, StateTransition currentAction, Process process);

        void ExecuteCodeActivity(Process process, State currentState, StateTransition transition);
    }
}
