using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator
{
    public class Triangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle (double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("Сторона треугольника не может быть отрицательной или равной 0!");

            _a = a;
            _b = b;
            _c = c;
        } 


        private double GetSemiPerimeter() 
        {
            var semiPerimeter =  (_a + _b + _c) / 2.0;
            if (semiPerimeter<_a|| semiPerimeter < _b || semiPerimeter < _c)
            {
                throw new ArgumentOutOfRangeException("Такого треугольника не существет!");
            }
            return semiPerimeter;
        }

        public bool IsRightTriangle()
        {
            double[] sides = new double[] { _a, _b, _c };
            Array.Sort(sides);
            return (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2));
            
        }


        public override double GetSquare()
        {
            var p = GetSemiPerimeter();
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }
}
