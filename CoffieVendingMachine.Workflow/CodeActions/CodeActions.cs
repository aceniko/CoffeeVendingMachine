using CoffeeVendingMachine.Workflow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.Workflow.CodeActions
{
    public static class CodeActions
    {
        public static void ChooseCoffee(Process process) {
            Console.WriteLine("Choose coffee type: \n");
            Console.WriteLine("0. LATTE");
            Console.WriteLine("1. MACCHIATO");
            Console.WriteLine("2. ESPRESSO");
            Console.WriteLine("3. AMERICANO");
            Console.WriteLine("4. CAPPUCINO");
            Console.WriteLine("5. Load More from DB");

            string input = Console.ReadLine();

            process.ActionOutput = input;
            
        }

        public static void SugarAndMilk(Process process) {
            Console.WriteLine("Sugar? (Y/N):");
            string sugar = Console.ReadLine();
            Console.WriteLine("Milk? (Y/N):");
            string milk = Console.ReadLine();

            process.ActionOutput = sugar + ";" + milk;
        }


        public static void Decoration(Process process) {
            Console.WriteLine("Decoration");
            Console.WriteLine("1. Caramelle");
            Console.WriteLine("2. Cream");
            Console.WriteLine("3. Extra Sugar");
            Console.WriteLine("4. Extra Milk");

            string input = Console.ReadLine();

            process.ActionOutput = input;
        }

        public static void Finish(Process process) {
            Console.WriteLine("Coffee preparation done.");
            Console.WriteLine(process.Coffee.PrintConfiguration());
        }

    }
}
