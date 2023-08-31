using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10_Garland
{
    internal class TColorLight : TLight
    {
        public TLightColor FColor { get; }

        public TColorLight(TLightColor color)
        {
                FColor = color;
        }

        public string GetColorAsString()
        {
            return FColor.ToString();
        }
    }
}
