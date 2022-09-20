using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Circle : IShape
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
            if(radius <= 0)
            {
                throw new ArgumentException("Значение радиуса должно быть положительным числом");
            }
        }
        public double Area()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
