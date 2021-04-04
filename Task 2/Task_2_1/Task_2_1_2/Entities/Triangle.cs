using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    public class Triangle : Figure
    {
        private int _a, _b, _c;

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
            if (!(A < B + C && B < A + C && C < A + B))
                throw new ArgumentException("Сторона треугольника не может быть больше суммы двух других сторон");
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
                    throw new ArgumentException("Строна треугольника должна быть больше нуля");
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
                    throw new ArgumentException("Строна треугольника должна быть больше нуля");
            }
        }
        public int C
        {
            get
            {
                return _c;
            }
            set
            {
                if (value > 0)
                    _c = value;
                else
                    throw new ArgumentException("Строна треугольника должна быть больше нуля");
            }
        }

        public int Perimeter => A + B + C;
        public double Area => Math.Sqrt(Perimeter * (Perimeter - 2 * A) * (Perimeter - 2 * B) * (Perimeter - 2 * C)) / 4;

        public override string ToString()
        {
            return $"Треугольник" + Environment.NewLine + $"Стороны треугольника равны а = {A}, b = {B}, c = {C}"
                + Environment.NewLine + $"Периметр: {Perimeter}" + Environment.NewLine 
                + $"Площадь: {Area}";
        }
    }
}
