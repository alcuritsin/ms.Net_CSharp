using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Patient_T:APatient
    {
        public bool Treatment { get; set; }   //Помощь оказана?

        public Patient_T(string name, int age, string сomplain, bool treatment)
        {
            Name = name;
            Age = age;
            Complain = сomplain;
            Treatment = treatment;
        }
    }
}
