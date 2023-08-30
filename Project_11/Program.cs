using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11_Quadratic_Equation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть коефіцієнти a, b і c для квадратного рівняння ax^2 + bx + c = 0:");

            double a, b, c;

            Console.Write("a: ");
            while (!double.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Ви ввели некоректне значення коефіцієнту, спробуйте знову");

            Console.Write("b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
                Console.WriteLine("Ви ввели некоректне значення коефіцієнту, спробуйте знову");

            Console.Write("c: ");
            while (!double.TryParse(Console.ReadLine(), out c))
                Console.WriteLine("Ви ввели некоректне значення коефіцієнту, спробуйте знову");

            Task task = new Task(a, b, c);
            Solver solver = new Solver();
            Solution solution = solver.Solve(task);

            Console.WriteLine(solution);

            Console.ReadKey();
        }
    }
}
