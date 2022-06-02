using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedLogger.Interfaces
{
    public interface IConfigService
    {
        /// <summary>
        /// Method serializes info from json file.
        /// </summary>
        /// <returns>Path to log files.</returns>
        public string GetPath();
    }
}
