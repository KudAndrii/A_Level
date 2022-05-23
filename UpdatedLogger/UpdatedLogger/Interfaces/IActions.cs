using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedLogger.Interfaces
{
    public interface IActions
    {
        /// <summary>
        /// Method has LogType = Info.
        /// </summary>
        /// <returns>Flag = true.</returns>
        public bool Start();

        /// <summary>
        /// Method throws BusinessException with specified massage.
        /// </summary>
        /// <returns>Nothing to return.</returns>
        public bool Skipp();

        /// <summary>
        /// Method throws Exception with specified massage.
        /// </summary>
        /// <returns>Nothing to return.</returns>
        public bool Broke();
    }
}
