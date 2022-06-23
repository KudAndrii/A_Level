using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ModuleTaskThree.Abstractions;
using ModuleTaskThree.DI;

namespace ModuleTaskThree
{
    public sealed class Logger
    {
        private static readonly Lazy<Logger> _lazy = new Lazy<Logger>(() => new Logger(new Container().Load().GetService<IConfigService>()));
        private readonly string _logPath;
        private readonly string _backupPath;
        private Logger(IConfigService configService)
        {
            _logPath = configService.LoggerConfig.LogPath;
            _backupPath = configService.LoggerConfig.BackupPath;
        }

        public static Logger Instance
        {
            get
            {
                return _lazy.Value;
            }
        }
    }
}
