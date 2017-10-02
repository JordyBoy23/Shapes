using System;

namespace Shapes{
    class App
    {
        Triangle triangle1 = new Triangle();

        public App()
        {
            
        }

        public void Run()
        {
            Console.Write("Enter the height of the triangle: ");
            triangle1.Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the base length of the triangle: ");
            triangle1.BaseLength = Convert.ToDouble(Console.ReadLine());


            Console.Write("The area of the triangle is: {0}", triangle1.GetArea()); 
        }
    }
}