using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    class Rectangle
    {
        public double RectangleArea(double height, double width)
        {
            return height * width;
        }

        public double RectanglePerimeter(double height, double width)
        {
            return height + width + height + width;
        }
    }
}
