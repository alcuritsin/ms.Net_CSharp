using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class Square : Figure, IFigure
    {
        private readonly double _side;
​
        public Square(double side) => _side = side;
​
        public double CalcArea()
        {
            Area = _side * _side;
            return Area;
        }
​
        public double CalcPerimeter()
        {
            Perimeter = _side * 4;
            return Perimeter;
        }
    }
}
