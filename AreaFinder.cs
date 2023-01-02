using System;

namespace AreaFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Circle circle = new Circle("Circle", 2);
            Triangle triangle = new Triangle("Triangle", 3, 4, 5);
            Console.WriteLine(circle.CalcSquare());
            Console.WriteLine(triangle.CalcSquare());
        }

        
    }
}
