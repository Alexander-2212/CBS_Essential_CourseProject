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
            foreach (TColorLight light in Lights)
            {
                Console.WriteLine($"{(light.IsOn ? "увімкнена" : "вимкнена")} - {light.GetColorAsString()}");
            }
        }
    }
}
