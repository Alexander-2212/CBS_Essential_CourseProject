using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11_Quadratic_Equation
{
    internal class Solution
    {
        public double? X1 { get; }
        public double? X2 { get; }
        public string Status { get; }

        public Solution(double x1, double x2)
        {
            X1 = x1;
            X2 = x2;
            Status = "Два корені";
        }

        public Solution(double x)
        {
            X1 = x;
            Status = "Один корінь";
        }

        public Solution()
        {
            Status = "Немає коренів";
        }

        public override string ToString()
        {
            switch (Status)
            {
                case "Два корені":
                    return $"Корені: x1 = {X1}, x2 = {X2}";
                case "Один корінь":
                    return $"Корінь: x = {X1}";
                default:
                    return "Немає коренів";
            }
        }
    }
}
