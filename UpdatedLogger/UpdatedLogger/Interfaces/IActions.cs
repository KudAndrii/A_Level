using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedLogger.Interfaces
{
    public interface IActions
    {
        public bool Start();
        public void Skipp();
        public void Broke();
    }
}
