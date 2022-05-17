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
    internal class ZooServices
    {
        public Creature[] GenerateZoo(int lenght)
        {
            Creature[] zoo = new Creature[lenght];
            Random random = new Random();
            for (int i = 0; i < zoo.Length; i++)
            {
                int typeOfCreature = random.Next(0, 6);
                switch (typeOfCreature)
                {
                    case 0:
                        zoo[i] = new Deer(Convert.ToBoolean(random.Next(0, 2)), (Name)random.Next(0, 7), (Colour)random.Next(0, 7));
                        break;
                    case 1:
                        zoo[i] = new Dolphin(Convert.ToBoolean(random.Next(0, 2)), (Name)random.Next(0, 7));
                        break;
                    case 2:
                        zoo[i] = new Elephant(Convert.ToBoolean(random.Next(0, 2)), (Name)random.Next(0, 7), (Colour)random.Next(0, 7));
                        break;
                    case 3:
                        zoo[i] = new Lion(Convert.ToBoolean(random.Next(0, 2)), (Name)random.Next(0, 7));
                        break;
                    case 4:
                        zoo[i] = new Shark(Convert.ToBoolean(random.Next(0, 2)), (Name)random.Next(0, 7));
                        break;
                    case 5:
                        zoo[i] = new Tiger(Convert.ToBoolean(random.Next(0, 2)), (Name)random.Next(0, 7));
                        break;
                }
            }

            return zoo;
        }

        public void MakeAllScream(Creature[] zoo)
        {
            foreach (var creature in zoo)
            {
                creature.Scream();
            }
        }

        public void MakeAllEat(Creature[] animals)
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
