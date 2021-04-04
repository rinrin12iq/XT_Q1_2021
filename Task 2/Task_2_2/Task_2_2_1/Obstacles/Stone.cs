using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2_1
{
    public class Stone : Obstacles
    {
        public Stone(int x, int y, int area)
        {
            this.X = x;
            this.Y = y;
            this.Area = area;
        }
    }
}
