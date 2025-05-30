using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.Circle
{
    public class Rectangle : IShape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double getArea()
        {
            return length * width;
        }
        public double getPerimeter()
        {
            return (length + width) * 2;
        }
    }
}