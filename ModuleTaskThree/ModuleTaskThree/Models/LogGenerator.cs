using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ModuleTaskThree.Models
{
    internal class LogGenerator
    {
        public LogGenerator()
        {
            var first = GenerateLogsAsync("Task #1");
            var second = GenerateLogsAsync("Task #2");
            Task.WaitAll(first, second);
        }

        /// <summary>
        /// Method sends info for logging 50 times.
        /// </summary>
        /// <param name="task">Info about Task, which running method.</param>
        private async Task GenerateLogsAsync(string task)
        {
            for (int i = 0; i < 50; i++)
            {
                await Task.Run(() => Logger.Instance.SaveLog($"Record number {i + 1} from {task}"));
                Thread.Sleep(10);
            }
        }
    }
}
