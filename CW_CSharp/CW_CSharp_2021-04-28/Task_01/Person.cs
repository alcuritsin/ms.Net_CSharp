using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        protected Person() { }
        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
