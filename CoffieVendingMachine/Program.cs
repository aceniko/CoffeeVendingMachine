// See https://aka.ms/new-console-template for more information
using CoffeeVendingMachine.Workflow;
using CoffeeVendingMachine.Workflow.Models;

Console.WriteLine("Coffee Vending Machine!");
IWorkflow workflow = new Workflow();
Process process = new Process();

workflow.OnInit(process);
while (process.CurrentState != 6) {
    workflow.ExecuteFlow(process.ProcessStates.FirstOrDefault(x => x.StateId == process.CurrentState), process);
}
