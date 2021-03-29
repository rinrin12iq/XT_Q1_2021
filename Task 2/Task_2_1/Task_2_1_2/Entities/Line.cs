using System;

namespace Task_2_1_2
{
    public class Line : Figure
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }

        public Line(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public Line(int x1, int y1, int x2, int y2)
        {
            Point1 = new Point(x1, y1);
            Point2 = new Point(x2, y2);
        }

        public double Length => Math.Sqrt(Math.Pow(Point1.X - Point2.X, 2) + Math.Pow(Point1.Y - Point2.Y, 2));

        public override string ToString()
        {
            return $"Линия" + Environment.NewLine + $"Координаты первой точки: {Point1}, Координаты второй точки: {Point2}"
                + Environment.NewLine + $"Длина линии: {Length}";
        }
    }
}
