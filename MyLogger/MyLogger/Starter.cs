using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger
{
    internal class Starter : IStarter
    {
        public void Run()
        {
            Random random = new Random();
            IActions actions = new Actions();
            IResult result = new Result();
            for (int i = 0; i < 100; i++)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        result = actions.StartMethod();
                        break;
                    case 1:
                        result = actions.SkippMethod();
                        break;
                    case 2:
                        result = actions.BrokeMethod();
                        break;
                }

                if (result.Status == false)
                {
                    string massage = "Action failed by a reason:";
                    Logger.Instance.ConsoleLogInfo(massage + " " + result.PropertyError, LogType.Error);
                }
            }
        }
    }
}
