using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Enums;

namespace Zoo.AbstractAnimals
{
    /// <summary>
    /// Progenitor of all animals.
    /// </summary>
    internal abstract class Creature : ICreature
    {
        protected Creature(bool inhale, Name name)
        {
            Inhale = inhale;
            Name = name.ToString();
            if (inhale)
            {
                Massage = $"{Name} is Crying.";
                Alive = true;
                Breathe(Inhale, Exhale);
            }
            else
            {
                Massage = $"{Name} is dead.";
            }
        }

        public string Name { get; protected set; }
        public string Colour { get; protected set; }
        public virtual int Limbs { get; protected set; }
        protected bool Inhale { get; set; }
        protected bool Exhale { get; } = false;
        protected bool Alive { get; set; }
        protected string Massage { get; set; }

        public void Eat(string food)
        {
            if (string.IsNullOrEmpty(food) && Alive)
            {
                Console.WriteLine("I need food.");
            }
            else if (Alive)
            {
                Console.WriteLine("I'm eating.");
            }
        }

        public abstract void Move(int limbs);

        public abstract void Scream();

        /// <summary>
        /// I can breath if i alive.
        /// </summary>
        /// <param name="inhale">This flag should be true, if i alive.</param>
        /// <param name="exhale">This flag is false.</param>
        protected void Breathe(bool inhale, bool exhale)
        {
            while (exhale)
            {
                if (inhale == true)
                {
                    inhale = false;
                    exhale = true;
                }

                if (exhale == true)
                {
                    exhale = false;
                    inhale = true;
                }
            }
        }
    }
}
