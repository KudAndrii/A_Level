using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Class1
    {
        public Class1()
        {
            DelegateOfClass1 = Program.Show;
        }

        public delegate void DelegateOfClass1Handler(bool flag);
        public DelegateOfClass1Handler DelegateOfClass1 { get; set; }

        public int Pow(int a, int b)
        {
            return a * b;
        }
    }
}
