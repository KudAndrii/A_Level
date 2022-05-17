using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    /// <summary>
    /// Implementation of this interface can breathe.
    /// </summary>
    internal interface IBreathe
    {
        public void Breathe(bool inhale, bool exhale);
    }
}
