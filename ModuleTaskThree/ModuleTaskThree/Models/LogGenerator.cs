using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTaskThree.Models
{
    internal class LogGenerator
    {
        public LogGenerator()
        {
            var first = Task.Run(() => GenerateLogs());
            var second = Task.Run(() => GenerateLogs());

            Task.WaitAll(first, second);
        }

        private async Task GenerateLogs()
        {
            for (int i = 0; i < 50; i++)
            {
            }
        }
    }
}
