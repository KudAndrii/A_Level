using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.AbstractAnimals
{
    internal abstract class MammalHunter : IBreathe, IWalk, IHunt, IEat
    {
        private bool _inhale;
        private bool _exhale = false;
        private bool _alive;
        private string _massage;
        protected MammalHunter(bool inhale, string name)
        {
            _inhale = inhale;
            Name = name;
            if (inhale)
            {
                _massage = "Cry.";
                Breathe(_inhale, _exhale);
            }
            else
            {
                _massage = $"{Name} is dead.";
            }

            Console.WriteLine(_massage);
        }

        public string Name { get; }
        public abstract int Legs { get; }
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
            Walk(Legs);
            Kill();
            return "Prey";
        }

        public void Walk(int legs)
        {
            Console.WriteLine($"I walk by my {legs} legs.");
        }
    }
}
