using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;
using AutoPark.Abstractions;

namespace AutoPark.Models.Cars
{
    internal class FuelCar : AbstractFuelCar
    {
        public FuelCar(ICountServices countServices, IEngineFactory engineFactory, string name, string body)
            : base(countServices, engineFactory.CreateFuelCarEngine(), name, body)
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
