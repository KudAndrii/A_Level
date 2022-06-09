using System;

namespace Delegates
{
    internal class Program
    {
        public static void Show(bool flag)
        {
            Console.WriteLine(flag);
        }

        private static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2(new Class1());
            var resultDelegate = c2.Calc(c2.DelegateForPow, 1, 3);
            c1.DelegateOfClass1.Invoke(resultDelegate.Invoke(2));
        }
    }
}
