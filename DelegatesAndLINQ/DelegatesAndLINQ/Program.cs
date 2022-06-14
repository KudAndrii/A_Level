using System;
using DelegatesAndLINQ.Delegates;
using DelegatesAndLINQ.LINQ;

namespace DelegatesAndLINQ
{
    public class Program
    {
        private static void Main(string[] args)
        {
            DelegateToys delegates = new DelegateToys();
            LINQToys linqToys = new LINQToys();
        }
    }
}
