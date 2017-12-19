using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class MachineInventory
    {
        public int grape = 1;
        public int orange = 1;
        public int lemon = 1;

        public void SubtractGrape()
        {
            grape = grape - 1;
        }

    }
}
