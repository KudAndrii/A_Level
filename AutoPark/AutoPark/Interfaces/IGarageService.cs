using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Interfaces
{
    internal interface IGarageService
    {
        /// <summary>
        /// Method generates garage with setted count of cars.
        /// </summary>
        /// <param name="machineCount">Needed count of cars.</param>
        /// <returns>Array of random cars.</returns>
        public ICar[] GenerateGarage(int machineCount);

        /// <summary>
        /// Method summ coast of all cars if garage.
        /// </summary>
        /// <param name="garage">Incoming garage.</param>
        /// <returns>Coast of all cars.</returns>
        public int CountCoast(ICar[] garage);

        /// <summary>
        /// Method sorts cars in garage by resourse consuming ascendenly.
        /// </summary>
        /// <param name="garage">Incoming garage.</param>
        /// <returns>Sorted array of cars.</returns>
        public ICar[] SortByResourseConsumption(ICar[] garage);
    }
}
