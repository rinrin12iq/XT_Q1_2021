using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    public class Rectangle : Figure
    {
        private int _a, _b;

        public Rectangle(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        public int A
        {
            get
            {
                return _a;
            }
            set
            {
                if (value > 0)
                    _a = value;
                else
                    throw new ArgumentException("Строна прямоугольника должна быть больше нуля");
            }
        }
        public int B
        {
            get
            {
                return _b;
            }
            set
            {
                if (value > 0)
                    _b = value;
                else
                    throw new ArgumentException("Строна прямоугольника должна быть больше нуля");
            }
        }

        public int Perimeter => 2 * (_a + _b);
        public int Area => _a * _b;

        public override string ToString()
        {
            return $"Прямоугольник" + Environment.NewLine + $"Сторона a: {_a}, сторона b: {_b}"
                + Environment.NewLine + $"Периметр: {Perimeter}" + Environment.NewLine + $"Площадь: {Area}";
        }
    }
}
