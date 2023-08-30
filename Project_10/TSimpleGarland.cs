using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10_Garland
{
    internal class TSimpleGarland : Garland
    {
        public TSimpleGarland()
        {
            Lights = new List<TLight>(12);

            for (int i = 0; i < 12; i++)
            {
                Lights.Add(new TLight());
            }
        }

        public override void PrintStateOfLights()
        {
            int index = 1;

            foreach (var light in Lights)
            {
                Console.WriteLine($"{index}. {(light.IsOn ? "ON" : "OFF")}");
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
