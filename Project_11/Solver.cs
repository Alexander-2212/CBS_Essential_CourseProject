using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11_Quadratic_Equation
{
    internal class Solver
    {
        public Solution Solve(Task task)
        {
            double a = task.A;
            double b = task.B;
            double c = task.C;
            double discriminant = CalculateDiscriminant(a, b, c);

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new Solution(discriminant, x1, x2);
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                return new Solution(discriminant, x);
            }
            else
            {
                return new Solution(discriminant);
            }
        }

        private double CalculateDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }
}
