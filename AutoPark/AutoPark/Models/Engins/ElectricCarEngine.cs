using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Models.Engins
{
    internal class ElectricCarEngine : IEngine
    {
        public ElectricCarEngine()
        {
            Power = 150;
        }

        public int Power { get; }
    }
}
