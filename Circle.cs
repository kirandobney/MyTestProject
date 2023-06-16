using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    public class Circle
    {
        
        
        
        public double CircleArea(double radius)
        {
            double unrounded = Math.PI * (radius * radius);
            return Math.Round(unrounded, 2);
        }

        public double CirclePerimeter(double radius)
        {
            double unrounded = 2 * (Math.PI * radius);
            return Math.Round(unrounded, 2);
        }
    }
}
