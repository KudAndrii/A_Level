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
    /// Example of some deer.
    /// </summary>
    internal class Deer : MammalHerbivore
    {
        public Deer(bool inhale, Name name, Colour colour)
            : base(inhale, name)
        {
            Colour = colour.ToString();
            Console.WriteLine($"Deer {Massage}");
        }

        public override void Move(int legs)
        {
            Console.Write($"Deer {Name}");
            base.Move(legs);
        }

        public override void Scream()
        {
            if (Alive)
            {
                Console.WriteLine("*Ultrasound*");
            }
        }
    }
}
