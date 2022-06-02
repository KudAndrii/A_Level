using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;
using AutoPark.Models.Engins;

namespace AutoPark.Models.Factorys
{
    internal class EngineFactory : IEngineFactory
    {
        public IEngine CreateElectricCarEngine()
        {
            return new ElectricCarEngine();
        }

        public IEngine CreateElectricTruckEngine()
        {
            return new ElectricTruckEngine();
        }

        public IEngine CreateFuelCarEngine()
        {
            return new FuelCarEngine();
        }

        public IEngine CreateFuelTrackEngine()
        {
            return new FuelTruckEngine();
        }
    }
}
