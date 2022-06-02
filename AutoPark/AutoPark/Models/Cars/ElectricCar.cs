using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Abstractions;
using AutoPark.Interfaces;
using AutoPark.Enums;

namespace AutoPark.Models.Cars
{
    internal class ElectricCar : AbstractElectricCar
    {
        public ElectricCar(IMachineCountService countService, IEngineFactory engineFactory, Names name, Bodys body)
            : base(countService, engineFactory.CreateElectricCarEngine(), name.ToString(), body.ToString())
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
