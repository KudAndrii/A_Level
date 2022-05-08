using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger
{
    public enum LogType
    {
        Error,
        Info,
        Warning
    }

    public sealed class Logger
    {
        private readonly string _path = @"..\..\..\log.txt";
        private List<string> _logText = new List<string>();
        private static Logger instance = null;
        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }

                return instance;
            }
        }

        public void ConsoleLogInfo(string massage, LogType logType)
        {
            DateTime dt = DateTime.Now;
            _logText.Add($"{dt} : {logType} : {massage}");
        }

        public void RecordLogInfo()
        {
            StringBuilder recordingText = new StringBuilder(_logText.Capacity);
            foreach (var line in _logText)
            {
                recordingText.Append(line + "\n");
            }

            recordingText.Remove(recordingText.Length - 2, 2);
            File.WriteAllText(_path, recordingText.ToString());
        }
    }
}
