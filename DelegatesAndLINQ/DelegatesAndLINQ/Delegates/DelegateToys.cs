using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLINQ.Delegates
{
    internal class DelegateToys
    {
        public DelegateToys()
        {
            SumList = Sum;
            SumList += Sum;
            TryCatchMethod(SomeMethod);
        }

        private event Func<int, int, int> SumList;
        private int Sum(int a, int b) => a + b;
        private void TryCatchMethod(Func<int> someMethod)
        {
            int forConsoleOutput = 0;
            try
            {
                forConsoleOutput = someMethod();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine(forConsoleOutput);
            }
        }

        private int SomeMethod()
        {
            var enumerationSumList = SumList.GetInvocationList();
            int result = 0;
            foreach (var method in enumerationSumList)
            {
                result += Convert.ToInt32(method.DynamicInvoke(2, 3));
            }

            return result;
        }
    }
}
