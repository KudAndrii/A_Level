using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger
{
    internal class Actions : IActions
    {
        public IResult StartMethod()
        {
            string massage = "Start method: StartMethod";
            Logger.Instance.ConsoleLogInfo(massage, LogType.Info);
            return new Result(true);
        }

        public IResult SkippMethod()
        {
            string massage = "Skipped logic in method: SkoppMethod";
            Logger.Instance.ConsoleLogInfo(massage, LogType.Warning);
            return new Result(true);
        }

        public IResult BrokeMethod()
        {
            string massage = "I broke a logic";
            return new Result(false, massage);
        }
    }
}
