using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            TSimpleGarland simpleGarland = new TSimpleGarland();
            simpleGarland.PrintStateOfLights();

            Console.WriteLine(new string('_', 30));

            TColorGarland colorGarland = new TColorGarland();
            colorGarland.PrintStateOfLights();

            Console.ReadKey();
        }
    }
}
