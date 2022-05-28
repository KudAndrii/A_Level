using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Models.Engins
{
    internal class FuelTruckEngine : IEngine
    {
        public FuelTruckEngine()
        {
            Power = 200;
        }

        public int Power { get; }
    }
}
