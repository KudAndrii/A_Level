using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal interface ISwim
    {
        public int Fins { get; set; }
        public void Swim(int fins);
    }
}
