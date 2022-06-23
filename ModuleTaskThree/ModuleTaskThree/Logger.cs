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
            _logPath = configService.LoggerConfig.LogPath;
            _backupPath = configService.LoggerConfig.BackupPath;
            _n = configService.BackupConfig.N;
            File.Delete(_logPath);
            Directory.Delete(_backupPath, true);
        }

        public event Action<string> BackupHandler;

        public static Logger Instance
        {
            get
            {
                return _lazy.Value;
            }
        }

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

        private bool Backup(int logsCount)
        {
            if (logsCount % _n == 0)
            {
                if (!Directory.Exists(_backupPath))
                {
                    Directory.CreateDirectory(_backupPath);
                }

                var dateTime = DateTime.Now;
                var milliseconds = dateTime.Millisecond;
                lock (_locker)
                {
                    File.Copy(_logPath, _backupPath + dateTime.ToString().Replace(':', '.') + milliseconds.ToString() + ".txt");
                }

                return true;
            }

            return false;
        }
    }
}
