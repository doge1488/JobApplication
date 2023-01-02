using System;

namespace AreaFinder
{
    class Program
    {
        static void Main(string[] args)
        {while (true)
            {
                Console.WriteLine("Press 1 , if you want to calculate area of a circle , press 2 if you want to  calculate area of a triangle and press 3 if you want to quit the application");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Circle();
                        continue;

                    case 2:
                        Triangle();
                        continue;
                    case 3:
                        break;

                    default:
                        Console.WriteLine("Invalid number, enter numbers 1-3");
                        continue;
                }
                break;
            }
            
        }

        static void Circle()
        {
            Console.WriteLine("Enter your radius");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your circle area is :" + 3.141 * b);
        }

        static void Triangle()
        {
            Console.WriteLine("Enter length of your first  side");
            double x = Convert.ToDouble(Console.ReadLine());
                 Console.WriteLine("Enter length of your second  side");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length of your third  side");
            double z = Convert.ToDouble(Console.ReadLine());
            double s = (x + y + z) / 2;
            double area = Math.Sqrt(s * (s - x) * (s - y) * (s - z));
            if (double.IsNaN(area))
            {
                Console.WriteLine("This triangle does not exist !");
            }
            else
            {
                Console.WriteLine("Your total area is : " + area);
            }
            if (x > y && x > z)
            {if (Math.Pow(x, 2) == Math.Pow(y, 2) + Math.Pow(z, 2))
                {
                    Console.WriteLine("Your triangle is right-angled");
                }
                else
                {
                    Console.WriteLine("Your triangle is not right-angled");
                }
            }
            if (y > x && y > z)
            {
                if (Math.Pow(y, 2) == Math.Pow(x, 2) + Math.Pow(z, 2))
                {
                    Console.WriteLine("Your triangle is right-angled");
                }
                else
                {
                    Console.WriteLine("Your triangle is not right-angled");
                }
            }
            if (z > y && z > x)
            {
                if (Math.Pow(z, 2) == Math.Pow(y, 2) + Math.Pow(x, 2))
                {
                    Console.WriteLine("Your triangle is right-angled");
                }
                else
                {
                    Console.WriteLine("Your triangle is not right-angled");
                }
            }
            else
            {
                Console.WriteLine("Your triangle is not right-angled");
            }
        }
    }
}
