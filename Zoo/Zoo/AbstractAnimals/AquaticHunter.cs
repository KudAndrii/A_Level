using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Enums;

namespace Zoo.AbstractAnimals
{
    /// <summary>
    /// Abstract aquatic hunter.
    /// </summary>
    internal abstract class AquaticHunter : Aquatic, IHunt
    {
        protected AquaticHunter(bool inhale, Name name)
            : base(inhale, name)
        {
        }

        public virtual void Kill()
        {
            if (Alive)
            {
                Console.WriteLine("Prey killed.");
            }
        }

        public virtual string Hunt()
        {
            string result = null;
            if (Alive)
            {
                Move(Limbs);
                Kill();
                result = "Prey";
            }

            return result;
        }

        public override void Scream()
        {
            base.Scream();
        }
    }
}
