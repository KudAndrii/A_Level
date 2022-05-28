using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Abstractions
{
    internal abstract class AbstractFuelCar : AbstractCar, IFuelCar
    {
        public AbstractFuelCar(IMachineCountService countService, IEngine engine, string name, string body)
            : base(countService, engine, name, body)
        {
            Engine = engine;
            Coast = countService.CountCoast(Name, Body, Engine.Power);
            TankVolume = countService.CountResourseVolume(Body, Engine);
        }

        public int TankVolume { get; }

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
