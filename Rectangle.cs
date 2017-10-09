using System;

namespace Shapes
{
    class Rectangle
    {
        private double width;
        private double length;

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if(value < 1 || value > double.MaxValue)
                {
                    throw new OverflowException();
                }
                width = value;
            }
        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if(value < 1 || value > double.MaxValue)
                {
                    throw new OverflowException();
                }
                length = value;
            }
        }

        public double GetArea()
        {
            return width * length;
        }
        
        public double GetPerimeter()
        {
            return 2 * (length+width);
        }
    }
}