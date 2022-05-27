using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Abstractions
{
    internal class AbstractFuelCar : AbstractCar, IFuelCar
    {
        public AbstractFuelCar(IMachineCountService countServices, IEngine engine, string name, string body)
            : base(name, body)
        {
            Engine = engine;
            Coast = countServices.CountCoast(Name, Body, Engine.Power);
            TankVolume = countServices.CountResourseVolume(Body, Engine);
            FuelConsumption = countServices.CountResourseConsumption(Body, Engine.Power);
        }

        public int TankVolume { get; }

        public int FuelConsumption { get; }

        public override void Move(int fuel)
        {
            base.Move(fuel);
            if (fuel > 0)
            {
                Console.Write(" on fuel traction.");
            }
        }
    }
}
