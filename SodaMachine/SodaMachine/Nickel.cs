using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Nickel
    {
        public int nickel = 20;

        public double NickelValue()
        {
            double nickel = .05;
            return nickel;
        }

        public void AddNickel()
        {
            nickel = nickel + 1;
        }

        public void SubtractNickel()
        {
            nickel = nickel - 1;
        }

        public void NickelCheck()
        {
            if (nickel <= 0)
            {
                Console.WriteLine("Sorry, there are not enough nickels in the machine to dispense.");
            }
        }
    }
}
