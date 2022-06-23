using ModuleTaskThree.Configs;

namespace ModuleTaskThree.Abstractions
{
    internal interface IConfigService
    {
        public BackupConfig BackupConfig { get; }
        public LoggerConfig LoggerConfig { get; }
    }
}