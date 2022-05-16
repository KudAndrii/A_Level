using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Enums;

namespace Zoo.AbstractAnimals
{
    internal abstract class AquaticHunter : Aquatic, IHunt
    {
        public virtual void Kill()
        {
            if (!Alive)
            {
                Console.WriteLine(Massage);
            }
            else
            {
                Console.WriteLine("Prey killed.");
            }
        }

        public virtual string Hunt()
        {
            string result = null;
            if (!Alive)
            {
                Console.WriteLine(Massage);
            }
            else
            {
                Move(Limbs);
                Kill();
                result = "Prey";
            }

            return result;
        }
    }
}
