using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Abstractions
{
    internal abstract class AbstractCar : ICar
    {
        public AbstractCar(string name, string body)
        {
            Name = name;
            Body = body;
        }

        public IEngine Engine { get; protected set; }
        public string Name { get; }
        public string Body { get; }

        public int Coast { get; protected set; }

        public virtual void Move(int fuel)
        {
            if (fuel > 0)
            {
                Console.Write("is moving");
            }
        }
    }
}
