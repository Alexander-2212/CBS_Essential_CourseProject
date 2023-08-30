using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_13
{
    internal class Rectangle
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }

        public Rectangle(Point point1, Point point2)
        {
            if (point1.X == point2.X || point1.Y == point2.Y)
                throw new ArgumentException("Дві точки лежать на одній прямій!");

            Point1 = point1;
            Point2 = point2;
        }

        public double Area()
        {
            return Math.Abs(Point1.X - Point2.X) * Math.Abs(Point1.Y - Point2.Y);
        }

        public double Perimeter()
        {
            return 2 * (Math.Abs(Point1.X - Point2.X) + Math.Abs(Point1.Y - Point2.Y));
        }

    }
}
