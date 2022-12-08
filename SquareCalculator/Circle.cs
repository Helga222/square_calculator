using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator
{ 
    public class Circle : Figure
    {
        private double _radius;
        public override double GetSquare() => _radius * _radius * Math.PI;
        public Circle(double radius)
        {
            if (radius<0)
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным!");
            _radius = radius;
        }
    }
}
