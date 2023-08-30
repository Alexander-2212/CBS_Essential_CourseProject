using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10_Garland
{
    abstract class Garland
    {
        protected List<TLight> Lights;
        public abstract void PrintStateOfLights();

        public abstract void SwitchLight(int index);

        public abstract void SwitchAllLights();
    }
}
