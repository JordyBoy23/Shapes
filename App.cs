using System;

namespace Shapes{
    class App
    {
        Triangle triangle1 = new Triangle(5,5);
        Rectangle rectangle1 = new Rectangle(3,3);
        
        public App(){}

        public void RunTriangle()
        {
            Console.WriteLine();
            Console.Write("Enter the height of the triangle: ");
            try
            {
                triangle1.Height = Convert.ToDouble(Console.ReadLine());
            }
            catch(OverflowException)
            {
                Console.WriteLine("Must be a positive number");
            }

            Console.WriteLine();
            Console.Write("Enter the base length of the triangle: ");
            try
            {
                triangle1.BaseLength = Convert.ToDouble(Console.ReadLine());
            }
            catch(OverflowException)
            {
                Console.WriteLine("Must be a positive number");
            }

            Console.Write(Environment.NewLine + "The area of the triangle1 is: {0}", triangle1.GetArea());
            Console.Write(Environment.NewLine + "The perimeter of triangle1 is {0}", triangle1.GetPerimeter());
        }

        public void RunRectangle()
        {   
            Console.WriteLine();
            Console.Write(Environment.NewLine + "Enter the length of the rectangle: ");
            try
            {
                rectangle1.Length = Convert.ToDouble(Console.ReadLine());
            }
            catch(OverflowException)
            {
                Console.WriteLine("Must be a positive number");
            }

            Console.Write(Environment.NewLine + "Enter the width of the triangle: ");
            try
            {
                rectangle1.Width = Convert.ToDouble(Console.ReadLine());
            }
            catch(OverflowException)
            {
                Console.WriteLine("Must be a positive number");
            }

            Console.Write(Environment.NewLine + "The area of the rectangle1 is: {0}", rectangle1.GetArea());
            Console.Write(Environment.NewLine + "The perimeter of rectangle1 is {0}", rectangle1.GetPerimeter() + Environment.NewLine);
        }
    }
}