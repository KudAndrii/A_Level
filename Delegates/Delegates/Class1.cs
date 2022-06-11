using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Class1
    {
        public Action<bool> ShowDelegate { get; set; }
        public int Pow(int a, int b)
        {
            return a * b;
        }
    }
}
