using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class MachineInventory
    {
        Penny penny = new Penny();
        Dime dime = new Dime();
        Nickel nickel = new Nickel();
        Quarter quarter = new Quarter();

        public void SubtractPenny()
        {
            penny = penny - 1;
        }

        public void PennyInventory()
        {
            int penny = 50;
        }

        public void QuarterInventory()
        {
            int quarter = 20;
        }

        public void DimeInventory()
        {
            int dime = 10;
        }

        public void NickelInventory()
        {
            int nicel = 20;
        }

    }
}
