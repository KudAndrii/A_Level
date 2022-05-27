using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Models.Engins
{
    internal class ElectricTruckEngine : IEngine
    {
        private string[] _details;
        public ElectricTruckEngine()
        {
            Power = 250;
        }

        public int Power { get; }
    }
}
