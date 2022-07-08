using FirstDatabase.Configs;

namespace FirstDatabase.Interfaces
{
    internal interface IConfigService
    {
        /// <summary>
        /// Gets config entity for database connection.
        /// </summary>
        /// <value>
        /// Conection string.
        /// </value>
        DBConfig DBConfig { get; }
    }
}