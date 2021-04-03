using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    public class Ring : Figure
    {
        public int X { get; set; }
        public int Y { get; set; }

        private int _innerRadius, _outerRadius;
        public int InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                if (_outerRadius != 0 && value > _outerRadius)
                    throw new ArgumentException("Внешний радиус должен быть больше внутреннего");
                if (value > 0)
                    _innerRadius = value;
                else
                    throw new ArgumentException("Данные введены некорректно");

            }
        }

        public int OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                if (value < _innerRadius)
                    throw new ArgumentException("Внешний радиус должен быть больше внутреннего");
                if (value > 0)
                    _outerRadius = value;
                else
                    throw new ArgumentException("Радиус должен быть больше нуля");
            }
        }

        public Ring(int x, int y, int r, int R)
        {
            X = x;
            Y = y;
            InnerRadius = r;
            OuterRadius = R;
        }

        public double Area => Math.PI * Math.Pow(OuterRadius, 2) - Math.PI * Math.Pow(InnerRadius, 2);
        public double InnerCircleLength => 2 * Math.PI * InnerRadius;
        public double OuterCircleLength => 2 * Math.PI * OuterRadius;


        public override string ToString()
        {
            return $"Кольцо" + Environment.NewLine + $"Координаты центра окружности: ({X},{Y})" + Environment.NewLine
                + $"Радиус внутренней окружности : {InnerRadius}" + Environment.NewLine 
                + $"Радиус внутренней окружности : {OuterRadius}" + Environment.NewLine 
                + $"Длина внутренней окружности: {InnerCircleLength}, длина внешней окружности: {OuterCircleLength}" 
                + Environment.NewLine + $"Площадь: {Area}"; ;
        }
    }
}
