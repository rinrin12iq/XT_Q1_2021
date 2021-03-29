using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    public class Disk : Circle
    {
        public Disk() : base() { }
        public Disk(int x, int y, int radius) : base(x, y, radius) { } 

        public double Area => Math.PI * Math.Pow(Radius, 2);

        public override string ToString()
        {
            return "Окружность" + Environment.NewLine + $"Координаты центра окружности: ({X},{Y}), Радиус: {Radius}"
                + Environment.NewLine + $"Длина окружности: {CircuitLength}" + Environment.NewLine
                + $"Площадь круга: {Area}";
        }
    }
}
