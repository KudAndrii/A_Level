using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using ModuleTaskThree.Abstractions;
using ModuleTaskThree.DI;

namespace ModuleTaskThree
{
    public sealed class Logger
    {
        private static readonly Lazy<Logger> _lazy = new Lazy<Logger>(() => new Logger(new Container().Load().GetService<IConfigService>()));
        private readonly object _locker = new object();
        private readonly string _logPath;
        private readonly string _backupPath;
        private int _logsCount;
        private int _n;
        private Logger(IConfigService configService)
        {
            // Getting needed fields.
            _logPath = configService.LoggerConfig.LogPath;
            _backupPath = configService.LoggerConfig.BackupPath;
            _n = configService.BackupConfig.N;

            // Deleting log file and directory for backups.
            File.Delete(_logPath);
            Directory.Delete(_backupPath, true);

            // Getting count of logs from log file if it exist.
            if (File.Exists(_logPath))
            {
                _logsCount = File.ReadAllLines(_logPath).Count();
            }
        }

        /// <summary>
        /// Notification about backuping.
        /// </summary>
        public event Action<string> BackupHandler;

        public static Logger Instance
        {
            get
            {
                return _lazy.Value;
            }
        }

        /// <summary>
        /// Method adding a massage to the log file.
        /// </summary>
        /// <param name="massage">Info for logging.</param>
        public void SaveLog(string massage)
        {
            lock (_locker)
            {
                File.AppendAllText(_logPath, massage + Environment.NewLine);
            }

            _logsCount++;
            if (Backup(_logsCount))
            {
                BackupHandler?.Invoke(massage);
            }
        }

        /// <summary>
        /// Method copys log file if it's necessary based on count of existing logs and _n.
        /// </summary>
        /// <param name="logsCount">Count of existing logs.</param>
        /// <returns>True, if backup was created; otherwise, false.</returns>
        private bool Backup(int logsCount)
        {
            if (logsCount % _n == 0)
            {
                if (!Directory.Exists(_backupPath))
                {
                    Directory.CreateDirectory(_backupPath);
                }

                dynamic dateTime = DateTime.Now;
                int milliseconds = dateTime.Millisecond;
                dateTime = dateTime.ToString().Replace(':', '.');
                lock (_locker)
                {
                    File.Copy(_logPath, _backupPath + dateTime + milliseconds + ".txt");
                }

                return true;
            }

            return false;
        }
    }
}
