using ModuleTaskThree.Configs;

namespace ModuleTaskThree.Abstractions
{
    internal interface IConfigService
    {
        /// <summary>
        /// Gets information about N.
        /// </summary>
        /// <value>Information about N.</value>
        public BackupConfig BackupConfig { get; }

        /// <summary>
        /// Gets information for Logger.
        /// </summary>
        /// <value>Information about log file path and backup directory.</value>
        public LoggerConfig LoggerConfig { get; }
    }
}