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

        public void SubtractNickel()
        {
            nickel = nickel - 1;
        }
    }
}
