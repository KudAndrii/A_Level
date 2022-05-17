using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.AbstractAnimals;
using Zoo.Enums;

namespace Zoo.Models
{
    /// <summary>
    /// Example of some dolphin.
    /// </summary>
    internal class Dolphin : AquaticHunter
    {
        public Dolphin(bool inhale, Name name)
            : base(inhale, name)
        {
            Colour = "Blue";
            Console.WriteLine($"Dolphin {Massage}");
        }

        public override void Move(int fins)
        {
            Console.Write($"Dolphin {Name}");
            base.Move(fins);
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
