using System;

namespace AreaFinder
{
    
        public abstract class Shape
        {
            public string figureName{get ; private set;}
            public Shape(string figureName)
            {
                this.figureName = figureName;
            }
            public abstract double CalcSquare();
        }
        public static class ShapePrototype
        {
            public static double CalcSquare(Shape shape) => shape.CalcSquare();

        }

        public class Circle : Shape
        {
            public double radius { get; private set; }
            public Circle(string figureName, double radius) : base(figureName)
            {
                this.radius = radius;

            }
            public override double CalcSquare()
            {
                return Math.Round(Math.PI * Math.Pow(radius , 2), 5);

            }
        }
        public class Triangle : Shape
        { public double x { get; private set; }
          public double y { get; private set; }
            public double z { get; private set; }
            public Triangle(string figureName, double x, double y, double z) : base(figureName)
            {
                if (x < 0 || y < 0 || z < 0)
                {
                    throw new ArgumentException($"Error : neither of your sides can be less than a zero!");
                }
                else if (x > (y + z) || y > (z + x) || z > (x + y))
                    throw new ArgumentException($"Error: your side is greater than the sum of two another sides");
                else
                {
                    this.x = x;
                    this.y = y;
                    this.z = z;
                }
            }
            public override double CalcSquare()
            {
                double s = (x + y + z) / 2;
                double area = Math.Sqrt(s * (s - x) * (s - y) * (s - z));
                return area;
            }

        
    }
}
