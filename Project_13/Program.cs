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

            Console.WriteLine("Введіть координати для першої точки:");
            Console.Write("X1: ");
            double x1;
            while (!double.TryParse(Console.ReadLine(), out x1))
                Console.WriteLine("Введіть коректне значення для X1:");


            Console.Write("Y1: ");
            double y1;
            while (!double.TryParse(Console.ReadLine(), out y1))
                Console.WriteLine("Введіть коректне значення для Y1:");


            Console.WriteLine("Введіть координати для другої точки:");
            Console.Write("X2: ");
            double x2;
            while (!double.TryParse(Console.ReadLine(), out x2))
                Console.WriteLine("Введіть коректне значення для X2:");


            Console.Write("Y2: ");
            double y2;
            while (!double.TryParse(Console.ReadLine(), out y2))
                Console.WriteLine("Введіть коректне значення для Y2:");

            Dot dot1 = new Dot(x1, y1);
            Dot dot2 = new Dot(x2, y2);

            try
            {
                Rectangle rectangle = new Rectangle(dot1, dot2);

                Console.WriteLine($"Площа прямокутника: {rectangle.Area()}");
                Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter()}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
