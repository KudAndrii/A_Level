using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Abstractions;
using AutoPark.Interfaces;

namespace AutoPark.Models.Cars
{
    internal class ElectricCar : AbstractElectricCar
    {
        public ElectricCar(ICountServices countServices, IEngineFactory engineFactory, string name, string body)
            : base(countServices, engineFactory.CreateElectricCarEngine(), name, body)
        {
        }

        public override void Move(int fuel)
        {
            if (fuel > 0)
            {
                Console.Write(Name + Body + " ");
            }

            base.Move(fuel);
        }
    }
}
