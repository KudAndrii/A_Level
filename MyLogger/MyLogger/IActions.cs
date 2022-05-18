using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger
{
    internal interface IActions
    {
        /// <summary>
        /// Method with some massage and logtype.
        /// </summary>
        /// <returns>class instance Result with status = true.</returns>
        public IResult StartMethod();

        /// <summary>
        /// Method with some massage and logtype.
        /// </summary>
        /// <returns>class instance Result with status = true.</returns>
        public IResult SkippMethod();

        /// <summary>
        /// Method with some massage and logtype.
        /// </summary>
        /// <returns>class instance Result with status = false.</returns>
        public IResult BrokeMethod();
    }
}
