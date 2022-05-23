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
    /// Example of some shark.
    /// </summary>
    internal class Shark : AquaticHunter
    {
        public Shark(bool inhale, Name name)
            : base(inhale, name)
        {
            Colour = "Blue";
            Console.WriteLine($"{nameof(Shark)} {Massage}");
        }

        public override void Move(int fins)
        {
            Console.Write($"{nameof(Shark)} {Name}");
            base.Move(fins);
        }

        public override void Scream()
        {
            if (Alive)
            {
                Console.Write($"{nameof(Shark)} {Name} : ");
                base.Scream();
            }
        }
    }
}
