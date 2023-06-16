using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    class Triangle
    {
        public double TriangleArea(double sideA, double sideB, double sideC)
        {
            double s = (sideA + sideB + sideC) / 2;
            double unrounded = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            
            return Math.Round(unrounded, 2);
        }

        public double TrianglePerimeter(double sideA, double sideB, double sideC)
        {
            return sideA + sideB + sideC;
        }
    }
}
