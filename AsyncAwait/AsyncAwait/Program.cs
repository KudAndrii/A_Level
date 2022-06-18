using System;

namespace AsyncAwait
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mb = new MassageBox();
            mb.Open();
            Console.ReadKey();
        }
    }
}
