using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10
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
            foreach (var light in Lights)
            {
                Console.WriteLine(light.IsOn ? "увімкнена" : "вимкнена");
            }
        }
    }
}
