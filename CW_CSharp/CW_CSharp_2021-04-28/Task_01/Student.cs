using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class Student : Person, IFaculty, IToString
    {
        public string Faculty { get; set; }

        public Student() { }
        public Student(string name, int age, string faculty) : base(name, age)
        {
            Faculty = faculty;
        }
​
        public override string ToString()
        {
            return $"Name: {Name}\tAge: {Age}\tFaculty: {Faculty}";
        }
    }
}
