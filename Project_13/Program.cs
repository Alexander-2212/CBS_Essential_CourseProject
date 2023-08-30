using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_13_Dot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Point point1 = new Point(0, 0);
            Point point2 = new Point(6, 4);

            Rectangle rectangle = new Rectangle(point1, point2);

            Console.WriteLine($"Площа прямокутника: {rectangle.Area()}");
            Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter()}");

            Console.ReadKey();
        }
    }
}
