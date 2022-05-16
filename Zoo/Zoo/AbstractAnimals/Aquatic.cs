using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Enums;

namespace Zoo.AbstractAnimals
{
    internal abstract class Aquatic : Creature
    {
        protected Aquatic(bool inhale, Name name)
            : base(inhale, name)
        {
        }

        public override int Limbs { get; protected set; } = 2;
        public override void Move(int fins)
        {
            if (!Alive)
            {
                Console.WriteLine(Massage);
            }
            else
            {
                Console.WriteLine($"I walk in the water by my {fins} fins.");
            }
        }

        public override void Scream()
        {
            if (!Alive)
            {
                Console.WriteLine(Massage);
            }
            else
            {
                Console.WriteLine("Bul-bul.");
            }
        }
    }
}
