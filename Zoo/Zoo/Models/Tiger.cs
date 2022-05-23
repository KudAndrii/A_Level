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
    /// Example of some tiger.
    /// </summary>
    internal class Tiger : MammalHunter
    {
        public Tiger(bool inhale, Name name)
            : base(inhale, name)
        {
            Colour = "Black&Yellow";
            Console.WriteLine($"{nameof(Tiger)} {Massage}");
        }

        public override void Move(int legs)
        {
            Console.Write($"{nameof(Tiger)} {Name}");
            base.Move(legs);
        }

        public override void Scream()
        {
            if (Alive)
            {
                Console.WriteLine($"{nameof(Tiger)} {Name} : Roar!");
            }
        }
    }
}
