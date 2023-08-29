using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10
{
    enum TLightColor
    {
        lcGreen = ConsoleColor.Green,
        lcRed = ConsoleColor.Red,
        lcYellow = ConsoleColor.Yellow,
        lcBlue = ConsoleColor.Blue
    }

    internal class TLight
    {
        public bool IsOn { get; set; }

        public void Switch()
        {
            IsOn = !IsOn;
        }
    }
}
