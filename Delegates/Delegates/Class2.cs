using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Class2
    {
        private readonly Class1 _class1;
        private int _result;

        public Class2(Class1 class1)
        {
            _class1 = class1;
        }

        public delegate int DelegateForPowHandler(int a, int b);
        public delegate bool DelegateForResultHandler(int a);
        public DelegateForPowHandler DelegateForPow { get; set; }
        public DelegateForResultHandler DelegateForResult { get; set; }

        public DelegateForResultHandler Calc(DelegateForPowHandler delegateForPow, int a, int b)
        {
            delegateForPow = _class1.Pow;
            _result = delegateForPow.Invoke(a, b);
            DelegateForResult = Result;
            return DelegateForResult;
        }

        public bool Result(int a)
        {
            if ((_result % a) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
