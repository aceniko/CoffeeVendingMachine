using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeVendingMachine.Workflow.Models.Transitions;

namespace CoffeeVendingMachine.Workflow.Models
{
    public class State
    {
        public int StateId { get; set; }
        public StateTransition Transition { get; set; }
    }
}
