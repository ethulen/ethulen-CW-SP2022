using System;
using System.Collections.Generic;

namespace SqrIsRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectangle> rectangles = new List<Rectangle>();

            Rectangle r1 = new Rectangle();
            r1.height = 4;
            r1.width = 5;
            rectangles.Add(r1);
            Console.WriteLine("Rectangle-01 Width: {0} x Height: {1} area is: {2}", r1.width, r1.height, r1.calculateArea().ToString());

            Rectangle r2 = new Rectangle();
            r2.width = 5;
            r2.height = 4;
            rectangles.Add(r2);
            Console.WriteLine("Rectangle-01 Width: {0} x Height: {1} area is: {2}", r2.width, r2.height, r2.calculateArea().ToString());

            bool match = (r1.height == r2.height) && (r1.width == r2.width);
            Console.WriteLine("Matching rectangles sides is {0}\n", match);


            Rectangle square1 = new SquareSquare();
            square1.height = 5;
            square1.width = 4;
            rectangles.Add(square1);
            Console.WriteLine("Rectangle-01 Width: {0} x Height: {1} area is: {2}", square1.width, square1.height, square1.calculateArea().ToString());

            Rectangle square2 = new SquareSquare();
            square2.width = 5;
            square2.height = 4;
            rectangles.Add(square2);
            Console.WriteLine("Rectangle-01 Width: {0} x Height: {1} area is: {2}", square2.width, square2.height, square2.calculateArea().ToString());

            bool match2 = (square1.height == square2.height) && (square1.width == square2.width);
            Console.WriteLine("Matching squares sides is {0}\n", match2);
        }
    }
}
