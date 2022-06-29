using System;

namespace AsyncAwait
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mb = new MassageBox();
            mb.Open();
            mb.WindowClosed += (State state) =>
            {
                if (state == State.OK)
                {
                    Console.WriteLine("Operation has been confirmed");
                }
                else
                {
                    Console.WriteLine("Operation was rejected");
                }
            };
            Console.ReadKey();
        }
    }
}
