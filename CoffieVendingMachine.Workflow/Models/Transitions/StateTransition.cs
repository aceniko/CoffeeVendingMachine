using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Workflow.Models.Transitions
{
    public abstract class StateTransition
    {
        public int CurrentState;
        private Action<Process> _action;
        public int ToStateId { get; set; }
        public StateTransition(int currentState, Action<Process> action)
        {
            CurrentState = currentState;
            _action = action;
        }

        public bool Equals(object obj)
        {
            StateTransition other = obj as StateTransition;
            return other != null && CurrentState == other.CurrentState && _action == other._action;
        }

        public virtual void Execute(Process process) {
            if (_action != null)
            {
                _action(process);
            }
        }
    }
}
