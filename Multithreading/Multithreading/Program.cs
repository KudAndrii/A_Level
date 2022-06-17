using System;
using System.Collections.Generic;
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
            Console.WriteLine("Before calling method in main");
            var result = p.ConcatAsync();
            Console.WriteLine(result.Result);
            Console.WriteLine("After calling method in main");
        }

        public async Task<string> GetWordAsync(string path)
        {
            Console.WriteLine("Start");
            var result = await Task.Run(() => File.ReadAllText(path));
            Thread.Sleep(2000);
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
