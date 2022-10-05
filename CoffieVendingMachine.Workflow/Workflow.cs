using CoffeeVendingMachine.Workflow.Models;
using CoffeeVendingMachine.Workflow.Models.Transitions;

namespace CoffeeVendingMachine.Workflow
{
    public class Workflow : IWorkflow
    {

        public void ExecuteCodeActivity(Process process, State currentState, StateTransition transition)
        {
            transition.Execute(process);
        }

        public void ExecuteFlow(State currentState, Process process)
        {

            if (currentState.Transition!=null) {
                ExecuteTransition(currentState, currentState.Transition, process);
            }
        }

        public void ExecuteTransition(State currentState, StateTransition transition, Process process)
        {
                ExecuteCodeActivity(process, currentState, transition);
        }

        public void OnInit(Process process)
        {
            process.CurrentState = 1;
        }
    }
}