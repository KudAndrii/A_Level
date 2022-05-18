using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger
{
    internal interface IStarter
    {
        /// <summary>
        /// Random call one of methods from class Actions 100 times.
        /// </summary>
        public void Run();
    }
}
