using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.AbstractAnimals;
using Zoo.Enums;

namespace Zoo.Models
{
    internal class Lion : MammalHunter
    {
        public Lion(bool inhale, Name name, Colour colour)
            : base(inhale, name)
        {
            Colour = colour.ToString();
        }

        public override void Scream()
        {
            if (!Alive)
            {
                Console.WriteLine(Massage);
            }
            else
            {
                Console.WriteLine("Roar");
            }
        }
    }
}
