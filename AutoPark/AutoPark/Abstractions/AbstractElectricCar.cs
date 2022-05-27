using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Abstractions
{
    internal abstract class AbstractElectricCar : AbstractCar, IElectricCar
    {
        public AbstractElectricCar(IMachineCountService countServices, IEngine engine, string name, string body)
            : base(name, body)
        {
            Engine = engine;
            Coast = countServices.CountCoast(Name, Body, Engine.Power);
            BatteryVolume = countServices.CountResourseVolume(Body, Engine);
            EnergyConsumption = countServices.CountResourseConsumption(Body, Engine.Power);
        }

        public int BatteryVolume { get; }

        public int EnergyConsumption { get; }

        public override void Move(int fuel)
        {
            base.Move(fuel);
            if (fuel > 0)
            {
                Console.Write(" on electric traction.");
            }
        }
    }
}
