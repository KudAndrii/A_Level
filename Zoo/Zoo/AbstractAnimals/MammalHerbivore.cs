using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interfaces;

namespace Zoo.AbstractAnimals
{
    internal abstract class MammalHerbivore : Mammal, IGraze
    {
        public string Graze()
        {
            string result = null;
            if (!Alive)
            {
                Console.WriteLine(Massage);
            }
            else
            {
                Move(Limbs);
                result = "Herb";
            }

            return result;
        }
    }
}
