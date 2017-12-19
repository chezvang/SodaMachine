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
        MachineInventory inventory = new MachineInventory();

        double cost;
        double amount;
        double change;
        double changeCoin;

        string sodaChoice;

        int quarterCoin;
        int dimeCoin;
        int nickelCoin;
        int pennyCoin;

        public void MenuPrompt()
        {
            Console.WriteLine("What would you like?");
            Console.WriteLine("\nGrape $0.60 \nOrange $0.35 \nLemon $0.06\n");
            sodaChoice = Console.ReadLine();
            Menu(sodaChoice);
        }

        public void Menu(string sodaChoice)
        {
            switch (sodaChoice)
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
                prompt.CoinReturn(quarterCoin, dimeCoin, nickelCoin, pennyCoin);
                Console.WriteLine("Enjoy your " + sodaChoice + " soda!");
            }
            else
            {
                Console.WriteLine("\nExact price detected. Enjoy your " + sodaChoice + "!");
            }
        }

        public void DispenseChange(double change)
        {
            changeCoin = change;
            CoinCheck(changeCoin);
        }

        public void CoinCheck(double changeCoin)
        {
            while(changeCoin < cost)
            {
                changeCoin += quarter.QuarterValue();
                quarter.SubtractQuarter();
                quarterCoin++;
                if(changeCoin > cost)
                {
                    quarterCoin--;
                    changeCoin -= quarter.QuarterValue();
                    quarter.AddQuarter();

                    changeCoin += dime.DimeValue();
                    dime.SubtractDime();
                    dimeCoin++;
                    if(changeCoin > cost)
                    {
                        dimeCoin--;
                        changeCoin -= dime.DimeValue();
                        dime.AddDime();

                        changeCoin += nickel.NickelValue();
                        nickel.SubtractNickel();
                        nickelCoin++;
                        if (changeCoin > cost)
                        {
                            nickelCoin--;
                            changeCoin -= nickel.NickelValue();
                            nickel.SubtractNickel();
                            if (changeCoin > cost)
                            {
                                changeCoin += penny.PennyValue();
                                penny.SubtractPenny();
                                pennyCoin++;
                            }

                        }
                    }
                }
            }
        }

        public void ActivateSodaMachine()
        {
            MenuPrompt();
            InsertCoins();
            CheckChange();
        }
    }
}
