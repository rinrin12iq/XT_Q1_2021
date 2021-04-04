using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2_1
{
    public class Field
    {
        private int _width, _heigth;

        public Field(int width, int heigth)
        {
            Width = width;
            Height = heigth;
        }

        public int Width
        {
            get => _width;
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new Exception("");
                }
            }
        }

        public int Height
        {
            get => _heigth;
            set
            {
                if (value > 0)
                {
                    _heigth = value;
                }
                else
                {
                    throw new Exception("");
                }
            }
        }

        public void CreateField()
        {

        }

        private void AddBonus(Bonus newBonus)
        {

        }

        private void AddObstacle(Obstacle newObstacle)
        {

        }

        private void AddUnit(Unit newUnit)
        {

        }
    }
}
