using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10
{
    internal class TColorGarland : Garland
    {
        public TColorGarland()
        {
            Lights = new List<TLight>(12);
            TLightColor[] colors =
            {
                TLightColor.lcGreen, TLightColor.lcRed, TLightColor.lcYellow, TLightColor.lcBlue
            };

            for (int i = 0; i < 12; i++)
            {
                Lights.Add(new TColorLight(colors[i % 4]));
            }
        }

        
        public override void PrintStateOfLights()
        {
            int index = 1;

            foreach (TColorLight light in Lights)
            {
                Console.ForegroundColor = (ConsoleColor)light.FColor;
                Console.WriteLine($"{index}. {(light.IsOn ? "ON" : "OFF")} - {light.GetColorAsString()}");
                Console.ForegroundColor = ConsoleColor.Gray;
                index++;
            }
        }

        public override void SwitchLight(int index)
        {
            if (index >= 0 && index < Lights.Count)
            {
                Lights[index].Switch();
            }
            else
            {
                Console.WriteLine("Невірний індекс лампочки.");
            }
        }

        public override void SwitchAllLights()
        {
            foreach (var light in Lights)
            {
                light.Switch();
            }
        }
    }
}
