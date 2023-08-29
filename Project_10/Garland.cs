using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10
{
    abstract class Garland
    {
        protected List<TLight> Lights;
        public abstract void PrintStateOfLights();
    }
}
