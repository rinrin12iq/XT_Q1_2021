using System;

namespace Task_2_1_2
{
    public class Circle : Figure
    {
        private int _radius;

        public Circle(int x, int y, int radius)
        {
            Radius = radius;
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value > 0)
                    _radius = value;
                else
                    throw new ArgumentException("Радиус должен быть больше нуля");
            }
        }

        public double CircuitLength => 2 * Math.PI * Radius;

        public override string ToString()
        {
            return "Окружность" + Environment.NewLine + $"Координаты центра окружности: ({X},{Y}), Радиус: {Radius}" 
                + Environment.NewLine + $"Длина окружности: {CircuitLength}";
        }
    }
}
