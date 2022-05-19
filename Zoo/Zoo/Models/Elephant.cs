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
    /// Example of some elephant.
    /// </summary>
    internal class Elephant : MammalHerbivore
    {
        public Elephant(bool inhale, Name name, Colour colour)
            : base(inhale, name)
        {
            Colour = colour.ToString();
            Console.WriteLine($"{nameof(Elephant)} {Massage}");
        }

        public override void Move(int legs)
        {
            Console.Write($"{nameof(Elephant)} {Name}");
            base.Move(legs);
        }

        public override void Scream()
        {
            if (Alive)
            {
                Console.WriteLine($"{nameof(Elephant)} {Name} : Trumpet!");
            }
        }
    }
}
