using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        Quarter quarter = new Quarter();
        Dime dime = new Dime();
        Nickel nickel = new Nickel();
        Penny penny = new Penny();
        Prompt prompt = new Prompt();

        double cost;
        double amount;
        double change;

        public void MenuPrompt()
        {
            Console.WriteLine("What would you like?");
            Console.WriteLine("\nGrape $0.60 \nOrange $0.35 \nLemon $0.06\n");
            string choice = Console.ReadLine();
            Menu(choice);
        }

        public void Menu(string choice)
        {
            switch (choice)
            {
                case "Grape":
                    Console.WriteLine("Please insert 60 cents");
                    cost = .60;
                    break;
                case "Orange":
                    Console.WriteLine("Please insert 35 cents");
                    cost = .35;
                    break;
                case "Lemon":
                    Console.WriteLine("Please insert 6 cents");
                    cost = .6;
                    break;
                default:
                    prompt.ChoicePrompt();
                    MenuPrompt();
                    break;
            }
        }

        public void InsertCoins()
        {
            Console.WriteLine("\nPlease insert coin(s). Enter the type of coin to insert.");
            Console.WriteLine("\n Quarter $0.25\n Dime $0.10\n Nickel $0.05\n Penny $0.01");
            string enteredAmount = Console.ReadLine();
            EnteredAmount(enteredAmount);
        }

        public void EnteredAmount(string enteredAmount)
        {
            switch(enteredAmount)
            {
                case "Quarter":
                    amount += quarter.QuarterValue();
                    prompt.PriceCheck(amount);
                    AmountCheck();
                    break;
                case "Dime":
                    amount += dime.DimeValue();
                    prompt.PriceCheck(amount);
                    AmountCheck();
                    break;
                case "Nickel":
                    amount += nickel.NickelValue();
                    prompt.PriceCheck(amount);
                    AmountCheck();
                    break;
                case "Penny":
                    amount += penny.PennyValue();
                    prompt.PriceCheck(amount);
                    AmountCheck();
                    break;
                default:
                    prompt.ChoicePrompt();
                    InsertCoins();
                    break;
            }
        }

        public void AmountCheck()
        {
            if (amount >= cost)
            {
                Console.WriteLine("\nEnjoy your soda!");
            }
            else if (amount < cost)
            {
                InsertCoins();
            }
        }


        public void CheckChange()
        {
            if (amount > cost)
            {
                change = amount - cost;
                Console.WriteLine("Your change is: " + change);
                DispenseChange(change);
            }
            else
            {
                Console.WriteLine("\nExact price detected. Enjoy your day!");
            }
        }

        public void DispenseChange(double change)
        {
            
        }

        public void ActivateSodaMachine()
        {
            MenuPrompt();
            InsertCoins();
            CheckChange();
        }
    }
}
