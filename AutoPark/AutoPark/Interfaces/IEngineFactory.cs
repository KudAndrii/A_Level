using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Interfaces
{
    public interface IEngineFactory
    {
        public IEngine CreateElectricCarEngine();
        public IEngine CreateElectricTruckEngine();
        public IEngine CreateFuelCarEngine();
        public IEngine CreateFuelTrackEngine();
    }
}
