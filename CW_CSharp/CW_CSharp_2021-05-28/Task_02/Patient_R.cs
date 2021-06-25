using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Patient_R:APatient
    {
        public string Diagnoz { get; set; }   //Диагноз поставлен

        public Patient_R(string name, int age, string сomplain, string diagnoz)
        {
            Name = name;
            Age = age;
            Complain = сomplain;
            Diagnoz = diagnoz;
        }

    }
}
