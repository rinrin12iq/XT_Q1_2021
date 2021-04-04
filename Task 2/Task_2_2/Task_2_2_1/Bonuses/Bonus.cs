using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2_1
{
    public abstract class Bonus
    {
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void BonusBuff()
        {

        }
    }
}
