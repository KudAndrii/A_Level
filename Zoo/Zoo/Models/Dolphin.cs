using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.AbstractAnimals;
using Zoo.Enums;

namespace Zoo.Models
{
    internal class Dolphin : AquaticHunter
    {
        public Dolphin(bool inhale, Name name)
            : base(inhale, name)
        {
        }

        public override void Scream()
        {
            base.Scream();
            if (Alive)
            {
                Console.WriteLine("*Ultrasound*");
            }
        }
    }
}
