using System;
using SixthInterfaceApplication.domain.shape;

namespace SixthInterfaceApplication
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            Console.WriteLine("원의 면적: " + circle.CalculateArea());
            Console.WriteLine("원의 둘레: " + circle.CalculatePerimeter());

            Console.WriteLine("\n사각형의 면적: " + rectangle.CalculateArea());
            Console.WriteLine("사각형의 둘레: " + rectangle.CalculatePerimeter());
        }
    }
}
