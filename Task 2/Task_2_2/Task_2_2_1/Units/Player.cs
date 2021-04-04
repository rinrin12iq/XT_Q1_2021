using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2_1
{
    public class Player : Unit
    {
        public Player(int x, int y, int health)
        {
            X = x;
            Y = y;
            HealthPoint = health;
        }

        public override void Move()
        {

        }

        public void TakeBonus()
        {

        }
    }
}
