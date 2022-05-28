using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Interfaces
{
    public interface IEngineFactory
    {
        /// <summary>
        /// Method creates electric engine for car.
        /// </summary>
        /// <returns>ElectricCarEngine.</returns>
        public IEngine CreateElectricCarEngine();

        /// <summary>
        /// Method creates electric engine for truck.
        /// </summary>
        /// <returns>ElectricTruckEngine.</returns>
        public IEngine CreateElectricTruckEngine();

        /// <summary>
        /// Method creates fuel engine for car.
        /// </summary>
        /// <returns>FuelCarEngine.</returns>
        public IEngine CreateFuelCarEngine();

        /// <summary>
        /// Method creates fuel engine for truck.
        /// </summary>
        /// <returns>FuelTruckEngine.</returns>
        public IEngine CreateFuelTrackEngine();
    }
}
