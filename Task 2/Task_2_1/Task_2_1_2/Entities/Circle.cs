using System;

namespace Task_2_1_2
{
    public class Circle : Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        private int _radius;

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

        public Circle(int x, int y, int radius)
        {
            Radius = radius;
            X = x;
            Y = y;
        }

        

        public double CircuitLength => 2 * Math.PI * Radius;

        public override string ToString()
        {
            return "Окружность" + Environment.NewLine + $"Координаты центра окружности: ({X},{Y}), Радиус: {Radius}" 
                + Environment.NewLine + $"Длина окружности: {CircuitLength}";
        }
    }
}
