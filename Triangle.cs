using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        double a;
        double b;
        double c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if (Validate() == false)
                throw new ArgumentException("Нарушена валидность данных");
        }

        public double Area()
        {
            double halfPerimeter = (a + b + c)/2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter-a) * (halfPerimeter-b) * (halfPerimeter-c));
        }

        public bool RightTriangle()
        {
            double area = Area();
            if ((area == (a*b)/2) || (area == (a * c) / 2) || (area == (c * b) / 2))
                return true;
            return false;
        }

        public bool Validate()
        {

            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Значение длины стороны должно быть положительным числом");
                return false;
            }
            if (((a + b) < c) || (a + c) < b || (b + c) < a)
            {
                throw new ArgumentException("Одна сторона треугольника больше суммы двух других сторон. Такой треугольник не может существовать");
                return false;
            }
            return true;
        }
    }
}
