using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Quarter
    {
        public int quarter = 20;

        public double QuarterValue()
        {
            double quarter = .25;
            return quarter;
        }

        public void AddQuarter()
        {
            quarter = quarter + 1;
        }

        public void SubtractQuarter()
        {
            quarter = quarter - 1;
        }

        public void QuarterCheck()
        {
            if (quarter <= 0)
            {
                Console.WriteLine("Sorry, there are not enough quarters in the machine to dispense.");
            }
        }
    }
}
