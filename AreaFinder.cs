
using System;

namespace AreaFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Circle", 2);
            Triangle triangle = new Triangle("Triangle", 3, 5, 5);
            Console.WriteLine($"Your circle area is: " + circle.CalcSquare());
            Console.WriteLine($"Your triangle area is: "+triangle.CalcSquare());
            if (Math.Pow(triangle.x, 2) == Math.Pow(triangle.y, 2) + Math.Pow(triangle.z, 2) || Math.Pow(triangle.y, 2) == Math.Pow(triangle.x, 2) + Math.Pow(triangle.z, 2) || Math.Pow(triangle.z, 2) == Math.Pow(triangle.y, 2) + Math.Pow(triangle.x, 2))
            {
                Console.WriteLine("Your triangle is right-angled");
            }
            else
            {
                Console.WriteLine("Your triangle is not right-angled");
            }

        }

        
    }
}
