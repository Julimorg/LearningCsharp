using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.Circle
{
    public class Circle : IShape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            return 3.14 * radius * radius;
        }


        public double getPerimeter()
        {
            return 2 * 3.14 * radius;
        }
    }
}