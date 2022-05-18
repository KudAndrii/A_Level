using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger
{
    internal class Result : IResult
    {
        public Result()
        {
        }

        public Result(bool status) => Status = status;
        public Result(bool status, string propertyError)
        {
            Status = status;
            PropertyError = propertyError;
        }

        public bool Status { get; }
        public string PropertyError { get; }
    }
}
