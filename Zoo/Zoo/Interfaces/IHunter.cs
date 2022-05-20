using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    /// <summary>
    /// Implementation of this interface can hunt.
    /// </summary>
    internal interface IHunter
    {
        public string Hunt();
        public void Kill();
    }
}
