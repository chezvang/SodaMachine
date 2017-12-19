using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Penny
    {

        private int penny = 50;

        public double PennyValue()
        {
            double penny = .01;
            return penny;
        }

        public void SubtractPenny()
        {
            penny = penny - 1;
        }
    }
}
