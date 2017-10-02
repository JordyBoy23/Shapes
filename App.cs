using System;

namespace Shapes{
    class App
    {
        Triangle triangle1 = new Triangle();
        Triangle triangle2 = new Triangle(5,5);

        public App()
        {
            
        }

        public void Run()
        {
            Console.Write("Enter the height of the triangle: ");
            try
            {
                triangle1.Height = Convert.ToDouble(Console.ReadLine());
            }
            catch(OverflowException)
            {
                Console.WriteLine("Must be a positive number");
            }

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

            Console.Write(Environment.NewLine + "The area of the triangle2 is: {0}", triangle2.GetArea()); 
            Console.Write(Environment.NewLine + "The perimeter of trangle 2 is: {0}", triangle2.GetPerimeter());
        }
    }
}