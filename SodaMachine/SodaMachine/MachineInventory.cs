using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class MachineInventory
    {
        //Penny penny = new Penny();
        //Dime dime = new Dime();
        //Nickel nickel = new Nickel();
        //Quarter quarter = new Quarter();
        public int penny = 50;
        public int nickel = 20;
        public int dime = 10;
        public int quarter = 20;

        public int Grape = 1;
        public int Orange = 1;
        public int Lemon = 1;

        public void SubtractPenny()
        {
            penny = penny - 1;
        }


    }
}
