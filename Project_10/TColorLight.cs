using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10
{
    internal class TColorLight : TLight
    {
        public TLightColor FColor { get; set; }

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
