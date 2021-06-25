using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public delegate void Actions();
    public delegate void Info(string msg);
    public abstract class Gates
    {
        public bool Status { get; set; }
        public string Name { get; set; }
    }
}
