using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.AbstractAnimals;
using Zoo.Models;

namespace Zoo.Extensions
{
    /// <summary>
    /// Extensions for zoo.
    /// </summary>
    internal static class Extentions
    {
        /// <summary>
        /// Method finds all hunters in array of animals.
        /// </summary>
        /// <param name="animals">Incoming array of animals.</param>
        /// <returns>Array of hunters.</returns>
        public static Creature[] GetAllHunters(this Creature[] animals)
        {
            int count = default;
            foreach (var animal in animals)
            {
                if (animal is MammalHunter || animal is AquaticHunter)
                {
                    count++;
                }
            }

            Creature[] hunters = new Creature[count];
            int j = default;
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i] is MammalHunter || animals[i] is AquaticHunter)
                {
                    hunters[j] = animals[i];
                    j++;
                }
            }

            return hunters;
        }

        /// <summary>
        /// Method finds all herbivores in array of animals.
        /// </summary>
        /// <param name="animals">Incoming array of animals.</param>
        /// <returns>Array of herbivores.</returns>
        public static Creature[] GetAllHerbivores(this Creature[] animals)
        {
            int count = default;
            foreach (var animal in animals)
            {
                if (animal is MammalHerbivore)
                {
                    count++;
                }
            }

            Creature[] herbivores = new Creature[count];
            int j = default;
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i] is MammalHerbivore)
                {
                    herbivores[j] = animals[i];
                    j++;
                }
            }

            return herbivores;
        }
    }
}
