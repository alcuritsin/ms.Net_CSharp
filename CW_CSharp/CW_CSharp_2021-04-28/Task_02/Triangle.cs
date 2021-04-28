using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public class Triangle :Shape, IArea, IPerimeter
    {
        private readonly double _sideA;   //  Длина стороны "A"
        private readonly double _sideB;   //  Длина стороны "B"
        private readonly double _sideC;   //  Длина стороны "C"

        //  Constructors
        public Triangle(double sideA,double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        //  Methods
        public double AreaCalc()
        {
            //  Формула герона
            //  S = sqrt(p * (p-a)*(p-b)*(p-c))
            //  где p - полупериметр
            //  p = (a+b+c)/2
            double p = PerimetrCalc()/2;    //  Полупериметр
            Area = Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
            return Area;
        }

        public double PerimetrCalc()
        {
            Perimeter = _sideA + _sideB + _sideC;
            return Perimeter;
        }
    }
}
