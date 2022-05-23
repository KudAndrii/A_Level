using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.AbstractAnimals;
using Zoo.Enums;
using Zoo.Models;

namespace Zoo
{
    /// <summary>
    /// Class for zoo managing.
    /// </summary>
    internal class ZooServices : IZooServices
    {
        private Random _random;
        public ZooServices(Random random)
        {
            _random = random;
        }

        /// <summary>
        /// Method generate array of random animals, with random name and colour (it can be dead too).
        /// </summary>
        /// <param name="lenght">Given lenght of array.</param>
        /// <returns>Random array of creatures.</returns>
        public ICreature[] GenerateZoo(int lenght)
        {
            ICreature[] zoo = new Creature[lenght];
            for (int i = 0; i < zoo.Length; i++)
            {
                int typeOfCreature = _random.Next(0, 6);
                switch (typeOfCreature)
                {
                    case 0:
                        zoo[i] = new Deer(Convert.ToBoolean(_random.Next(0, 2)), (Name)_random.Next(0, 7), (Colour)_random.Next(0, 7));
                        break;
                    case 1:
                        zoo[i] = new Dolphin(Convert.ToBoolean(_random.Next(0, 2)), (Name)_random.Next(0, 7));
                        break;
                    case 2:
                        zoo[i] = new Elephant(Convert.ToBoolean(_random.Next(0, 2)), (Name)_random.Next(0, 7), (Colour)_random.Next(0, 7));
                        break;
                    case 3:
                        zoo[i] = new Lion(Convert.ToBoolean(_random.Next(0, 2)), (Name)_random.Next(0, 7));
                        break;
                    case 4:
                        zoo[i] = new Shark(Convert.ToBoolean(_random.Next(0, 2)), (Name)_random.Next(0, 7));
                        break;
                    case 5:
                        zoo[i] = new Tiger(Convert.ToBoolean(_random.Next(0, 2)), (Name)_random.Next(0, 7));
                        break;
                }
            }

            return zoo;
        }

        /// <summary>
        /// Method makes scream all animals of incoming array individualy.
        /// </summary>
        /// <param name="zoo">Incoming array of creatures.</param>
        public void MakeAllScream(ICreature[] zoo)
        {
            foreach (var creature in zoo)
            {
                creature.Scream();
            }
        }

        /// <summary>
        /// Method makes eat all animals of incoming array individualy.
        /// </summary>
        /// <param name="animals">Incoming array of animals.</param>
        public void MakeAllEat(ICreature[] animals)
        {
            foreach (var animal in animals)
            {
                if (animal is MammalHunter)
                {
                    MammalHunter hunter = animal as MammalHunter;
                    hunter.Eat(hunter.Hunt());
                }
                else if (animal is AquaticHunter)
                {
                    AquaticHunter hunter = animal as AquaticHunter;
                    hunter.Eat(hunter.Hunt());
                }
                else
                {
                    MammalHerbivore herbivore = animal as MammalHerbivore;
                    herbivore.Eat(herbivore.Graze());
                }
            }
        }
    }
}
