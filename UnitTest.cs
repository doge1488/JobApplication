using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MindBoxLib.Tests
{
   
    public class CircleTest
    {
      
        public void TestTriangle()
        {
           
            Circle circle = new Circle("Circle",21);
            double expected = 1385,44236;

            
            double result = circle.CalcSquare();

         
            Assert.AreEqual(expected, result);
        }
    }

    public class TriangleTest
    {
      
        public void TestTriangle()
        {
           
            Triangle triangle = new Triangle("Triangle", 3, 4, 6);
            double expected =5,33268225192539 ;

            
            double result = triangle.CalcSquare();

          
            Assert.AreEqual(expected, result);
        }

        
    }
}
