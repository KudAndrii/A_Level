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
    /// Example of some lion.
    /// </summary>
    internal class Lion : MammalHunter
    {
        public Lion(bool inhale, Name name)
            : base(inhale, name)
        {
            Colour = "Yellow";
            Console.WriteLine($"Lion {Massage}");
        }

        public override void Move(int legs)
        {
            Console.Write($"Lion {Name}");
            base.Move(legs);
        }

        public override void Scream()
        {
            if (Alive)
            {
                Console.WriteLine("King's Roar!");
            }
        }
    }
}
