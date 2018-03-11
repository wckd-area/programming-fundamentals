//CONFIRMED from myilkova
using System;

namespace _2.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double rectangleWidth = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = rectangleWidth * height;
            Console.WriteLine($"{result:f2}");
        }
    }
}
