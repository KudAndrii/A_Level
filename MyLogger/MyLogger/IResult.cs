using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger
{
    internal interface IResult
    {
        public bool Status { get; }
        public string PropertyError { get; }
    }
}
