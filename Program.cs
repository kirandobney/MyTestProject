using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Rectangle r = new Rectangle();
            Triangle t = new Triangle();
            bool trianglecomplete = false;

            
            



            Console.WriteLine("Hello, please input a value for a circle's radius");
            double radius = Convert.ToDouble(Console.ReadLine());
            string CircleArea = Convert.ToString(c.CircleArea(radius));
            string CirclePerimeter = Convert.ToString(c.CirclePerimeter(radius));
            Console.WriteLine("The area of this circle is " + CircleArea + ", and its perimeter is " + CirclePerimeter );
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();

            Console.WriteLine("Please input a value for a rectangle's height");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input a value for this rectangle's width");
            double width = Convert.ToDouble(Console.ReadLine());
            string RectangleArea = Convert.ToString(r.RectangleArea(height, width));
            string RectanglePerimeter = Convert.ToString(r.RectanglePerimeter(height, width));
            Console.WriteLine("The area of this rectangle is " + RectangleArea + ", and its perimeter is " +  RectanglePerimeter );
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();


            while (trianglecomplete == false)
            {
                Console.WriteLine("Please input a value for the length of one of a triangle's sides");
                double sideA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please input a value for the length of the second side of this triangle");
                double sideB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please input a value for the length of the final side of the triangle");
                double sideC = Convert.ToDouble(Console.ReadLine());

                if (double.IsNaN(t.TriangleArea(sideA, sideB, sideC)))
                {
                    Console.WriteLine("That is not a valid triangle, press enter to try again");
                    Console.ReadKey ();
                }
                else
                {
                    string TriangleArea = Convert.ToString(t.TriangleArea(sideA, sideB, sideC));
                    string TrianglePerimeter = Convert.ToString(t.TrianglePerimeter(sideA, sideB, sideC));
                    Console.WriteLine("The area of this triangle is " + TriangleArea + ", and its perimeter is " + TrianglePerimeter);
                    trianglecomplete = true;
                }
            }

            Console.WriteLine("Thank you, press enter to finish");
            Console.ReadKey();
        }
    }
}
