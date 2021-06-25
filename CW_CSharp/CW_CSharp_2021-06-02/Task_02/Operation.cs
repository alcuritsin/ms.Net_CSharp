using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public class Operation
    {
        public double Calc(double num1, double num2, Operations op)
        {
            return op.Invoke(num1, num2);
        }
    }
}
