//CONFIRMED from myilkova
using System;

namespace _2.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // naming the double variables and reading from the console
            double rectangleWidth = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            // calculating rectangle area
            double result = rectangleWidth * height;

            // printing out output in correct format
            Console.WriteLine($"{result:f2}");
        }
    }
}
