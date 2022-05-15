using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.AbstractAnimals
{
    internal abstract class MammalHunter : Mammal, IHunt
    {
        public virtual string Hunt()
        {
            if (!Alive)
            {
                Console.WriteLine(Massage);
            }
            else
            {
                Walk(Legs);
                Kill();
                return "Prey";
            }

            return null;
        }
    }
}
