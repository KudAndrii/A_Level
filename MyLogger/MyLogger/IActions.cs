using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger
{
    internal interface IActions
    {
        public IResult StartMethod();
        public IResult SkippMethod();
        public IResult BrokeMethod();
    }
}
