using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_13_Dot
{
    internal class Rectangle
    {
        public Dot Dot1 { get; }
        public Dot Dot2 { get; }

        public Rectangle(Dot dot1, Dot dot2)
        {
            if (dot1.X == dot2.X || dot1.Y == dot2.Y)
                throw new ArgumentException("Дві точки лежать на одній прямій!");

            Dot1 = dot1;
            Dot2 = dot2;
        }

        public double Area()
        {
            return Math.Abs(Dot1.X - Dot2.X) * Math.Abs(Dot1.Y - Dot2.Y);
        }

        public double Perimeter()
        {
            return 2 * (Math.Abs(Dot1.X - Dot2.X) + Math.Abs(Dot1.Y - Dot2.Y));
        }

    }
}
