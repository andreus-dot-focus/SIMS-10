using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_10
{
    class HardDice:Dice
    {
        public HardDice()
        {
            ps = new double[6] { 0, 0, 0, 0, 1/2f, 1/2f};
        }
    }
}
