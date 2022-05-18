using System;

namespace MyLogger
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Starter starter = new Starter();
            starter.Run();
            Logger.Instance.RecordLogInfo();
        }
    }
}
