using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedLogger.Interfaces
{
    public interface IStarter
    {
        /// <summary>
        /// Method calls randomly one of Actions method 100 times.
        /// </summary>
        public void Run();
    }
}
