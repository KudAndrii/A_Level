using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.AbstractAnimals
{
    internal abstract class Mammal : IBreathe, IWalk, IEat
    {
        public string Name { get; protected set; }
        public int Legs { get; protected set; } = 4;
        protected bool Inhale { get; set; }
        protected bool Exhale { get; set; } = false;
        protected bool Alive { get; set; }
        protected string Massage { get; set; }

        public void Breathe(bool inhale, bool exhale)
        {
            while (true)
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

        public void Eat(string food)
        {
            if (!Alive)
            {
                Console.WriteLine(Massage);
            }
            else if (string.IsNullOrEmpty(food))
            {
                Console.WriteLine("I need food.");
            }
            else
            {
                Console.WriteLine("I'm eating.");
            }
        }

        public void Kill()
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

        public void Walk(int legs)
        {
            if (!Alive)
            {
                Console.WriteLine(Massage);
            }
            else
            {
                Console.WriteLine($"I walk by my {legs} legs.");
            }
        }

        public abstract void Scream();
    }
}
