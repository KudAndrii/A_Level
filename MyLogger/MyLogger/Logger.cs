using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger
{
    public sealed class Logger
    {
        private readonly string _path = @"..\..\..\log.txt";
        private List<string> _logList = new List<string>();

        /// <summary>
        /// Pattern Singleton implementation.
        /// </summary>
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

        /// <summary>
        /// Method adding log to the _logList, and showing this log in console.
        /// </summary>
        /// <param name="massage">Log massage.</param>
        /// <param name="logType">Log type (Info, Warning or Error).</param>
        public void ConsoleLogInfo(string massage, LogType logType)
        {
            DateTime dt = DateTime.Now;
            _logList.Add($"{dt} : {logType} : {massage}");
            Console.WriteLine(_logList[_logList.Count - 1]);
        }

        /// <summary>
        /// Method Recording all info from _logList to the file log.txt.
        /// </summary>
        public void RecordLogInfo()
        {
            StringBuilder recordingText = new StringBuilder(_logList.Capacity);
            foreach (var line in _logList)
            {
                recordingText.Append(line + "\n");
            }

            recordingText.Remove(recordingText.Length - 1, 1);
            File.WriteAllText(_path, recordingText.ToString());
        }
    }
}
