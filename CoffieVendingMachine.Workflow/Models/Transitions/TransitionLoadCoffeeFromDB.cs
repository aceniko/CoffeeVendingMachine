using CoffeeVendingMachine.DataAccess.Manager;
using CoffeeVendingMachine.Objects.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Workflow.Models.Transitions
{
    internal class TransitionLoadCoffeeFromDB : StateTransition
    {
        private IDataManager _dataManager;
        private IBuilder _builder;
        public TransitionLoadCoffeeFromDB(int currentState, Action<Process> action) : base(currentState, action)
        {
            _dataManager = new DataManager();
            _builder = new CustomCoffeeBuilder();
        }

        public override void Execute(Process process)
        {
            ToStateId = process.CurrentState;
            try
            {
                base.Execute(process);

                var externalCoffees = _dataManager.GetCoffees();

                foreach (var coffe in externalCoffees)
                {
                    Console.WriteLine(coffe.Name);
                }
                Console.WriteLine("Type the coffee name:");
                string input = Console.ReadLine();
                if (!externalCoffees.Any(x => x.Name.Equals(input, StringComparison.OrdinalIgnoreCase))){
                    throw new Exception("Invalid coffee name!");
                }
                process.ActionOutput = input;
                _builder.CreateCoffee(Core.Enums.CoffeeType.EXTERNAL);
                process.Coffee = _builder.GetCoffie();
                process.Coffee.Name = input;
                ToStateId = 2;
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
