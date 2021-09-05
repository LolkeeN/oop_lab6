using System;
using System.Collections.Generic;

namespace Veselov_V_O_oop_lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.setName("myRectangle");
            rectangle.setLetgth(5);
            rectangle.setWidth(8);
            rectangle.delegateWork();

            Triangle triangle = new Triangle();
            triangle.setName("myTriangle");
            triangle.delegateWork();

            Rectangle rectangle2 = new Rectangle();
            rectangle2.setName("myRectangle2");
            Triangle triangle2 = new Triangle();
            triangle2.setName("myTriangle2");


            List<Rectangle> rectangles = new List<Rectangle>();
            rectangles.Add(rectangle);
            rectangles.Add(rectangle2);
            Console.WriteLine("rectangles list: ");
            foreach (Rectangle rectangle1 in rectangles) {
                Console.Write(rectangle1 + "\n");
            }

            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(triangle);
            triangles.Add(triangle2);
            Console.WriteLine("triangles list: ");
            foreach (Triangle triangle1 in triangles)
            {
                Console.Write(triangle1 + "\n");
            }

        }
    }
}
