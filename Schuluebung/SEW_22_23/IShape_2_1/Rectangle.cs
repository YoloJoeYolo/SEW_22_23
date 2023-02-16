using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShape_2_1
{
    internal class Rectangle : IShape
    {
        private double sideA;
        private double sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public double CalculateArea()
        {
            return Math.Round(sideA * sideB, 2);
        }

        public double CalculateCircumference()
        {
            return Math.Round(2 * sideA + 2* sideB, 2);
        }
    }
}
