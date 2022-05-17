using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interfaces;
using Zoo.Enums;

namespace Zoo.AbstractAnimals
{
    internal abstract class MammalHerbivore : Mammal, IGraze
    {
        protected MammalHerbivore(bool inhale, Name name)
            : base(inhale, name)
        {
        }

        public string Graze()
        {
            string result = null;
            if (Alive)
            {
                Move(Limbs);
                Console.WriteLine("I'm greazing");
                result = "Herb";
            }

            return result;
        }
    }
}
