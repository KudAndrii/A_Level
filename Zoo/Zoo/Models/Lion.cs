using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.AbstractAnimals;
using Zoo.Enums;

namespace Zoo.Models
{
    internal class Lion : MammalHunter, IHunt
    {
        public Lion(bool inhale, Name name)
        {
            Inhale = inhale;
            Name = name.ToString();
            if (inhale)
            {
                Massage = "Cry.";
                Alive = true;
                Breathe(Inhale, Exhale);
            }
            else
            {
                Massage = $"{Name} is dead.";
            }

            Console.WriteLine(Massage);
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
