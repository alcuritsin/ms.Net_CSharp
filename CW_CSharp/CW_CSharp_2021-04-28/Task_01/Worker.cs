using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public abstract class Worker : Person
    {
        public double Salary { get; set; }

        protected Worker() { }
        protected Worker(string name, int age, double salary) : base(name, age)
        {
            Salary = salary;
        }
    }
}
