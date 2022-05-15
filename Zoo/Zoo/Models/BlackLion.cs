using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Enums;

namespace Zoo.Models
{
    internal class BlackLion : Lion
    {
        public BlackLion(bool inhale, Name name, Colour colour)
            : base(inhale, name)
        {
            Colour = colour.ToString();
        }

        public string Colour { get; }
    }
}
