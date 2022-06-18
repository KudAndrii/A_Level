using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var sw = new Stopwatch();
            Console.WriteLine("Before calling method in main");
            sw.Start();
            var result = p.ConcatAsync();
            sw.Stop();
            Console.WriteLine(result.Result);
            Console.WriteLine("After calling method in main");
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public async Task<string> GetWordAsync(string path)
        {
            Console.WriteLine("Start");
            var result = await Task.Run(() => File.ReadAllText(path));
            Thread.Sleep(10000);
            Console.WriteLine("End");
            return result;
        }

        public async Task<string> ConcatAsync()
        {
            var hello = GetWordAsync("../../../Hello.txt");
            Console.WriteLine("Second call");
            var world = GetWordAsync("../../../World.txt");
            return hello.Result + " " + world.Result + "!";
        }
    }
}
