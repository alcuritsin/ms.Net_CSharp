using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public class Square : Shape, IArea, IPerimeter
    {
        private readonly double _sidiA;   //  Длина стороны

        //  Constructors
        public Square(double sideA)
        {
            _sidiA = sideA;
        }

        //  Methods
        public double AreaCalc()
        {
            Area = _sidiA * _sidiA;
            return Area;
        }

        public double PerimetrCalc()
        {
            Perimeter = _sidiA * 4;
            return Perimeter;
        }
    }
}
