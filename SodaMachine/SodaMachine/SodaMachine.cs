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
        double dispenseCoin;

        string sodaChoice;

        int quarterCoin;
        int dimeCoin;
        int nickelCoin;
        int pennyCoin;

        int quarterEnter;
        int dimeEnter;
        int nickelEnter;
        int pennyEnter;

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
                    cost = .06;
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
            Console.WriteLine("\n Quarter $0.25\n Dime $0.10\n Nickel $0.05\n Penny $0.01\n None");
            string enteredAmount = Console.ReadLine();
            EnteredAmount(enteredAmount);
        }

        public void EnteredAmount(string enteredAmount)
        {
            switch(enteredAmount)
            {
                case "Quarter":
                    amount += quarter.QuarterValue();
                    quarterEnter++;
                    prompt.PriceCheck(amount);
                    AmountCheck();
                    break;
                case "Dime":
                    amount += dime.DimeValue();
                    dimeEnter++;
                    prompt.PriceCheck(amount);
                    AmountCheck();
                    break;
                case "Nickel":
                    amount += nickel.NickelValue();
                    nickelEnter++;
                    prompt.PriceCheck(amount);
                    AmountCheck();
                    break;
                case "Penny":
                    amount += penny.PennyValue();
                    pennyEnter++;
                    prompt.PriceCheck(amount);
                    AmountCheck();
                    break;
                case "None":
                    NoneCheck();
                    break;
                default:
                    prompt.ChoicePrompt();
                    InsertCoins();
                    break;
            }
        }

        public void NoneCheck()
        {
            Console.WriteLine("You have choosen not to enter any more coins. Your total was " + amount + " and is not enough. \nDispensing money entered...");
            Console.ReadKey();
            prompt.CoinReturn(quarterEnter, dimeEnter, nickelEnter, pennyEnter);
        }

        public void AmountCheck()
        {
            if (amount >= cost)
            {
                Console.WriteLine("\nEnjoy your " + sodaChoice + " soda!");
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
                Console.WriteLine("\nYour change is: " + change);
                DispenseChange(change);
                prompt.CoinReturn(quarterCoin, dimeCoin, nickelCoin, pennyCoin);
                Console.WriteLine("\nEnjoy your " + sodaChoice + " soda!");
            }
            else
            {
                if (amount < cost)
                {
                    Console.WriteLine("\nYou did not enter enough money. Terminating Soda Machine...");
                }
                else
                {
                    Console.WriteLine("\nExact price detected. Enjoy your " + sodaChoice + " soda!");
                }
            }
        }

        public void DispenseChange(double change)
        {
            changeCoin = change;
            CoinCheck(changeCoin);
        }

        public void CoinCheck(double changeCoin)
        {
            while(dispenseCoin < changeCoin)
            {
                dispenseCoin += quarter.QuarterValue() + .01;
                quarter.SubtractQuarter();
                quarterCoin++;
                if(dispenseCoin > changeCoin)
                {
                    quarterCoin--;
                    dispenseCoin -= quarter.QuarterValue();
                    quarter.AddQuarter();

                    dispenseCoin += dime.DimeValue();
                    dime.SubtractDime();
                    dimeCoin++;

                    if (dispenseCoin > changeCoin)
                    {
                        dimeCoin--;
                        dispenseCoin -= dime.DimeValue();
                        dime.AddDime();

                        dispenseCoin += nickel.NickelValue();
                        nickel.SubtractNickel();
                        nickelCoin++;

                        if (dispenseCoin > changeCoin)
                        {
                            nickelCoin--;
                            dispenseCoin -= nickel.NickelValue();
                            nickel.SubtractNickel();

                            dispenseCoin += penny.PennyValue();
                            penny.SubtractPenny();
                            pennyCoin++;
                            if (dispenseCoin > changeCoin)
                            {
                                pennyCoin--;
                                dispenseCoin -= penny.PennyValue();
                                penny.SubtractPenny();
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
