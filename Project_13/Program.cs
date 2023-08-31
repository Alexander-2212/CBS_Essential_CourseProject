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

            Dot dot1 = new Dot(0, 0);
            Dot dot2 = new Dot(6, 4);

            Rectangle rectangle = new Rectangle(dot1, dot2);

            Console.WriteLine($"Площа прямокутника: {rectangle.Area()}");
            Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter()}");

            Console.ReadKey();
        }
    }
}
