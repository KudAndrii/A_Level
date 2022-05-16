using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal interface IMove
    {
        public int Limbs { get; }
        public void Move(int limbs);
    }
}
