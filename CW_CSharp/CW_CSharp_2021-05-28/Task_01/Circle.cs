using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class Circle : Figure, IFigure
    {
        private const double PI = 3.14;
​
        private readonly double _radius;
​
        public Circle(double radius) => _radius = radius;
​
        public double CalcPerimeter()
        {
            Perimeter = 2 * PI * _radius;
            return Perimeter;
        }
​
        public double CalcArea()
        {
            Area = PI * _radius * _radius;
            return Area;
        }
    }
}
