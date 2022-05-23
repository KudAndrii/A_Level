using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdatedLogger.Interfaces;
using UpdatedLogger.DIcontainer;
using Microsoft.Extensions.DependencyInjection;
using UpdatedLogger.Enums;
using UpdatedLogger.FileServices;

namespace UpdatedLogger.Logger
{
    internal sealed class MyLogger : IMyLogger
    {
        public void AddLog(string massage, LogType logType)
        {
            FileService.Instance.AddToFile($"{DateTime.Now.ToString()} : {logType} : {massage}");
        }

        public void AddLog(string massage, LogType logType, string exceptionMassage)
        {
            FileService.Instance.AddToFile($"{DateTime.Now.ToString()} : {logType} : {massage + exceptionMassage}");
        }
    }
}
