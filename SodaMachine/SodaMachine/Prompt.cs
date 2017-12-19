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

        public void CoinReturn(int quarter, int dime, int nickel, int penny)
        {
            Console.WriteLine("Your change in quarters are: " + quarter + " quarters");
            Console.WriteLine("Your change in dimes are: " + dime + " dimes");
            Console.WriteLine("Your change in nickels are: " + nickel + " nickels");
            Console.WriteLine("Your change in pennies are: " + penny + " pennies");
        }
    }
}
