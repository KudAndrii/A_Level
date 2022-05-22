using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdatedLogger.Interfaces;
using UpdatedLogger.DIcontainer;
using Microsoft.Extensions.DependencyInjection;
using UpdatedLogger.Enums;

namespace UpdatedLogger.Logger
{
    internal sealed class MyLogger
    {
        private static readonly Lazy<MyLogger> Lazy = new Lazy<MyLogger>(() => new MyLogger(new Container().Load().GetService<IFileService>()));
        private IFileService _fileService;
        private MyLogger(IFileService fileService)
        {
            _fileService = fileService;
        }

        public static MyLogger Instance
        {
            get { return Lazy.Value; }
        }

        public void AddLog(string massage, LogType logType)
        {
            _fileService.AddToFile($"{DateTime.Now.ToString()} : {logType} : {massage}");
        }

        public void AddLog(string massage, LogType logType, Exception exception)
        {
            _fileService.AddToFile($"{DateTime.Now.ToString()} : {logType} : {massage + exception.Message}");
        }
    }
}
