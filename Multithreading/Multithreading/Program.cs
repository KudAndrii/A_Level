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
            var result = p.ConcatAsync();
            Console.WriteLine(result.Result);
        }

        public async Task<string> GetWordAsync(string path)
        {
            return await Task.Run(() => File.ReadAllText(path));
        }

        public async Task<string> ConcatAsync()
        {
            string hello = await GetWordAsync("../../../Hello.txt");
            string world = await GetWordAsync("../../../World.txt");
            return hello + " " + world + "!";
        }
    }
}
