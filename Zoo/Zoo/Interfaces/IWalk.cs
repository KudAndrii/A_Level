using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal interface IWalk
    {
        public int Legs { get; }
        public void Walk(int legs);
    }
}
