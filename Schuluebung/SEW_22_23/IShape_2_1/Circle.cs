using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShape_2_1
{
    internal class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.Round(Math.Sqrt(radius) * Math.PI, 2);
        }

        public double CalculateCircumference()
        {
            return Math.Round(2* radius * Math.PI, 2);
        }
    }
}
