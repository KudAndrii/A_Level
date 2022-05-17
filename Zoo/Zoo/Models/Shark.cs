using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.AbstractAnimals;
using Zoo.Enums;

namespace Zoo.Models
{
    internal class Shark : AquaticHunter
    {
        public Shark(bool inhale, Name name)
            : base(inhale, name)
        {
            Colour = "Blue";
            Console.WriteLine($"Shark {Massage}");
        }

        public override void Move(int fins)
        {
            Console.Write($"Shark {Name}");
            base.Move(fins);
        }
    }
}
