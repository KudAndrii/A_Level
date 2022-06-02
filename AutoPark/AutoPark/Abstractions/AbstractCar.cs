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
        public AbstractCar(IMachineCountService countService, IEngine engine, string name, string body)
        {
            Engine = engine;
            Name = name;
            Body = body;
            ResourseConsumption = countService.CountResourseConsumption(Body, Engine.Power);
        }

        public IEngine Engine { get; protected set; }
        public string Name { get; }
        public string Body { get; }
        public int ResourseConsumption { get; }

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
