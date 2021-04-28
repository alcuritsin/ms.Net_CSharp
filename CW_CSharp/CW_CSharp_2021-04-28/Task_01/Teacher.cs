using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class Teacher : Worker, IFaculty, IToString
    {
        public string Faculty { get; set; }

        public Teacher() { }
        public Teacher(string name, int age, double salary, string faculty) : base(name, age, salary)
        {
            Faculty = faculty;
        }

        public override string ToString()
        {
            return $"Name: {Name}\tAge: {Age}\tFaculty: {Faculty}";
        }
    }
}
