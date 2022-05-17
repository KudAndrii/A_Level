using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Enums;

namespace Zoo.AbstractAnimals
{
    internal abstract class Creature : IBreathe, IEat, IMove
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
        protected bool Exhale { get; set; } = false;
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
        public void Breathe(bool inhale, bool exhale)
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
