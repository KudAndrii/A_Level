using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Models.Engins
{
    internal class FuelCarEngine : IEngine
    {
        private string[] _details;
        public FuelCarEngine()
        {
            Power = 100;
        }

        public int Power { get; }
    }
}