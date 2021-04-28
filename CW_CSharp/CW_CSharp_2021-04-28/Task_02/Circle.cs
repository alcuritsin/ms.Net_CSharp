using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Circle : Shape, IArea, IPerimeter
    {
        private readonly double _radius;   // Длина радиуса
        private const double Pi = 3.14;
        
        //  Constructors
        public Circle(double radius)
        {
            _radius = radius;
        }

        //  Methods
        public double AreaCalc()
        {
            Area = Pi * (_radius * _radius);
            return Area;
        }

        public double PerimetrCalc()
        {
            Perimeter = 2 * _radius * Pi;
            return Perimeter;
        }
    }
}
