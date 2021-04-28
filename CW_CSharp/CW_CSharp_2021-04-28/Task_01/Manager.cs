using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class Manager : Worker, IToString
    {
        public string Position { get; set; }

        public Manager() { }
        public Manager(string name, int age, double salary, string position) : base(name, age, salary)
        {
            Position = position;
        }
​
        public override string ToString()
        {
            return $"Name: {Name}\tAge: {Age}\tPosition: {Position}";
        }
    }
}
