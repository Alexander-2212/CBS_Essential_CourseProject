using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10_Garland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            TSimpleGarland simpleGarland = new TSimpleGarland();
            Console.WriteLine("Стан звичайної гірлянди:");
            simpleGarland.PrintStateOfLights();

            simpleGarland.SwitchAllLights(); // Вмикання всіх лампочок
            Console.WriteLine("\nЗмінений стан звичайної гірлянди:");
            simpleGarland.PrintStateOfLights();

            TColorGarland colorGarland = new TColorGarland();
            Console.WriteLine("\nСтан кольорової гірлянди:");
            colorGarland.PrintStateOfLights();

            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                colorGarland.SwitchLight(random.Next(12));
            }

            Console.WriteLine("\nЗміненний стан кольорової гірлянди:");
            colorGarland.PrintStateOfLights();

            Console.ReadKey();
        }
    }
}
