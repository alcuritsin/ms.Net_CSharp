using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class Abiturient : Person, IFaculty
    {
        public string Faculty { get; set; }
        //string IFaculty.Faculty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
