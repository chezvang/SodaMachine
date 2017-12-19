using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class MachineInventory
    {
        public int grape = 0;
        public int orange = 1;
        public int lemon = 1;

        public void SubtractInventory(string sodaChoice)
        {
            switch(sodaChoice)
            {
                case "Grape":
                    InventoryCheck(sodaChoice);
                    grape = grape - 1;
                    break;
                case "Orange":
                    InventoryCheck(sodaChoice);
                    orange = orange - 1;
                    break;
                default:
                    InventoryCheck(sodaChoice);
                    lemon = lemon = 1;
                    break;
            }
        }

        public void InventoryCheck(string sodaChoice)
        {
            switch(sodaChoice)
            {
                case "Grape":
                    if(grape != 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry, there is no more grape soda.");
                    }
                    break;
                case "Orange":
                    if (orange != 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry, there is no more orange soda.");
                    }
                    break;
                default:
                    if (lemon != 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry, there is no more lemon soda.");
                    }
                    break;
            }
        }
    }
}
