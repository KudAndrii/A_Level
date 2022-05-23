using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedLogger.Interfaces
{
    public interface IFileService
    {
        /// <summary>
        /// Method creates file for list of logs.
        /// </summary>
        public void CreateFile();

        /// <summary>
        /// Method adds log to specified file.
        /// </summary>
        /// <param name="log">Log massage.</param>
        public void AddToFile(string log);

        /// <summary>
        /// Method checks count of log files.
        /// </summary>
        /// <returns>True - if count of files less then 3, false - if count of files more then 3.</returns>
        public bool CheckLogFilesCount();

        /// <summary>
        /// Method deletes the oldest log file.
        /// </summary>
        public void DeleteOldFile();
    }
}
