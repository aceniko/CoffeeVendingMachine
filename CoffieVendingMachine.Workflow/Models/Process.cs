using CoffeeVendingMachine.Core.Models;
using CoffeeVendingMachine.Workflow.Models.Transitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Workflow.Models
{
    public class Process
    {
        public BaseCoffee Coffee { get; set; }
        public int CurrentState { get; set; }

        public Action OnInitAction { get; set; }

        public List<State> ProcessStates { get; set; }

        public object ActionOutput;

        public Process() {
            ProcessStates = new List<State>
            {
                new State{ StateId = 1, Transition = new TransitionChooseCoffeeType(CurrentState, CodeActions.CodeActions.ChooseCoffee) },
                new State {StateId = 2, Transition = new TransitionChooseSugarMilk(CurrentState, CodeActions.CodeActions.SugarAndMilk)},
                new State {StateId = 3, Transition = new TransitionChooseDecoration(CurrentState, CodeActions.CodeActions.Decoration)},
                new State {StateId = 4, Transition = new TransitionLoadCoffeeFromDB(CurrentState, null)},
                new State {StateId = 5, Transition = new TransitionFinish(CurrentState, CodeActions.CodeActions.Finish)}
            };
        }

       
    }
}
