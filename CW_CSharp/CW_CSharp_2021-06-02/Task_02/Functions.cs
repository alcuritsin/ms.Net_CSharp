using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public class Functions
    {
        public Message Info;
        public Message Error;

        public double Add(double num1, double num2)
        {
            var result = num1 + num2;
            Info?.Invoke($"{num1} + {num2} = {result}");
            return result;
        }

        public double Max(double num1, double num2)
        {
            double result;
            if (num1 > num2)
            {
                result = num1;
                Info?.Invoke($"{num1} > {num2}");
            }
            else
            {
                result = num2;
                Info?.Invoke($"{num2} > {num1}");
            }
            return result;
        }

        public double Div(double num1, double num2)
        {
            if (num2 == 0)
            {
                Error?.Invoke("Делить на ноль нельзя!");
                throw new Exception("Делить на ноль нельзя!");
            }
            else
            {
                var result = num1 / num2;
                Info?.Invoke($"{num1} / {num2} = {result}");
                return result;
            }
        }
    }
}
