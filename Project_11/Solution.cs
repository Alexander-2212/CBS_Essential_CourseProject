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
        public double Discriminant { get; }
        public string Status { get; }

        public Solution(double discriminant, double x1, double x2)
        {
            Discriminant = discriminant;
            X1 = x1;
            X2 = x2;
            Status = "Два корені";
        }

        public Solution(double discriminant, double x)
        {
            Discriminant = discriminant;
            X1 = x;
            Status = "Один корінь";
        }

        public Solution(double discriminant)
        {
            Discriminant = discriminant;
            Status = "Немає коренів";
        }

        public override string ToString()
        {
            string result = $"Дискримінант: {Discriminant}\n";

            switch (Status)
            {
                case "Два корені":
                    result += $"Розрахунки коренів:\n";
                    result += $"x1 = (-b + √D) / 2a = {X1}\n";
                    result += $"x2 = (-b - √D) / 2a = {X2}";
                    break;
                case "Один корінь":
                    result += $"Розрахунки коренів:\n";
                    result += $"x = -b / 2a = {X1}";
                    break;
                default:
                    result += "Немає коренів.";
                    break;
            }
            return result;
        }
    }
}
