using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Enums;

namespace Zoo.AbstractAnimals
{
    /// <summary>
    /// Abstract mammal animal.
    /// </summary>
    internal abstract class Mammal : Creature
    {
        protected Mammal(bool inhale, Name name)
            : base(inhale, name)
        {
        }

        public override int Limbs { get; protected set; } = 4;
        public override void Move(int legs)
        {
            if (Alive)
            {
                Console.WriteLine($" walk on the ground by my {legs} legs.");
            }
        }
    }
}
