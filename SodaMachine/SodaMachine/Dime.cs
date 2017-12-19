using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Dime
    {
        public int dime = 10;

        public double DimeValue()
        {
            double dime = .10;
            return dime;
        }

        public void SubtractDime()
        {
            dime = dime - 1;
        }
    }
}
