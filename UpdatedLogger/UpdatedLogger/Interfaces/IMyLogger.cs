using UpdatedLogger.Enums;

namespace UpdatedLogger.Logger
{
    internal interface IMyLogger
    {
        /// <summary>
        /// Method forms log from incoming info, and calls special service to write this log in log file.
        /// </summary>
        /// <param name="massage">Special massage from Actions method.</param>
        /// <param name="logType">Type of log for current log.</param>
        void AddLog(string massage, LogType logType);

        /// <summary>
        /// Method forms log from incoming info, and calls special service to write this log in log file.
        /// </summary>
        /// <param name="massage">Special massage from Actions method.</param>
        /// <param name="logType">Type of log for current log.</param>
        /// <param name="exceptionMassage">Massage from incoming exception.</param>
        void AddLog(string massage, LogType logType, string exceptionMassage);
    }
}