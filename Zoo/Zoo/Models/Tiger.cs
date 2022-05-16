using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.AbstractAnimals;
using Zoo.Enums;

namespace Zoo.Models
{
    internal class Tiger : MammalHunter
    {
        public Tiger(bool inhale, Name name)
            : base(inhale, name)
        {
            Colour = "Black&Yellow";
        }

        public override void Scream()
        {
            if (!Alive)
            {
                Console.WriteLine(Massage);
            }
            else
            {
                Console.WriteLine("Roar!");
            }
        }
    }
}
