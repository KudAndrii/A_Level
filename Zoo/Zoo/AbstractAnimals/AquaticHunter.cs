using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.AbstractAnimals
{
    internal abstract class AquaticHunter : IBreathe, ISwim, IHunt, IEat
    {
        private bool _inhale;
        private bool _exhale = false;
        private bool _alive;
        private string _massage;
        protected AquaticHunter(bool inhale, string name)
        {
            _inhale = inhale;
            Name = name;
            if (inhale)
            {
                _massage = "Bul-Bul.";
                Breathe(_inhale, _exhale);
            }
            else
            {
                _massage = $"{Name} is dead.";
            }

            Console.WriteLine(_massage);
        }

        public string Name { get; }
        public abstract int Fins { get; }
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
            if (!_alive)
            {
                Console.WriteLine(_massage);
            }
            else if (string.IsNullOrEmpty(food))
            {
                Console.WriteLine("I need food.");
            }
        }

        public void Kill()
        {
            Console.WriteLine("Prey killed.");
        }

        public virtual string Hunt()
        {
            Swim(Fins);
            Kill();
            return "Prey";
        }

        public void Swim(int fins)
        {
            Console.WriteLine($"I walk by my {fins} legs.");
        }

        public abstract void Scream();
    }
}
