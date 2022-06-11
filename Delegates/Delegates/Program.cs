using System;

namespace Delegates
{
    internal class Program
    {
        public static void Show(bool result)
        {
            Console.WriteLine(result);
        }

        private static void Main(string[] args)
        {
            var class1 = new Class1();
            var class2 = new Class2();
            Show(class2.Calc(class1.Pow, 3, 3).Invoke(2));
        }
    }
}
