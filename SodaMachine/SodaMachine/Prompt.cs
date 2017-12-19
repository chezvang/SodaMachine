using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Prompt
    {
        public void ChoicePrompt()
        {
            Console.WriteLine("Please select an available choice");
            Console.ReadKey();
            Console.Clear();
        }

        public void PriceCheck(double amount)
        {
            Console.Clear();
            Console.WriteLine("\nTotal Entered: " + amount);
        }
    }
}
