using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Class2
    {
        private int _powResult;
        public Predicate<int> Calc(Func<int, int, int> powDelegate, int a, int b)
        {
            _powResult = powDelegate(a, b);
            return Result;
        }

        public bool Result(int a)
        {
            return _powResult % a == 0;
        }
    }
}
