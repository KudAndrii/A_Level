﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.AbstractAnimals
{
    internal abstract class Mammal : Creature
    {
        public override int Limbs { get; protected set; } = 4;
        public override void Move(int legs)
        {
            if (!Alive)
            {
                Console.WriteLine(Massage);
            }
            else
            {
                Console.WriteLine($"I walk on the ground by my {legs} legs.");
            }
        }
    }
}
