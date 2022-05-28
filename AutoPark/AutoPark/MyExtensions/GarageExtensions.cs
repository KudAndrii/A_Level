using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;
using AutoPark.Abstractions;

namespace AutoPark.MyExtensions
{
    internal static class GarageExtensions
    {
        /// <summary>
        /// Method searching all trucks in incoming garage.
        /// </summary>
        /// <param name="garage">Incoming garage.</param>
        /// <returns>Array of trucks.</returns>
        public static ICar[] GetAllTrucks(this ICar[] garage)
        {
            return FIndByBody(garage, "Truck");
        }

        /// <summary>
        /// Method searching all cars in incoming garage.
        /// </summary>
        /// <param name="garage">Incoming garage.</param>
        /// <returns>Array of cars.</returns>
        public static ICar[] GetAllCars(this ICar[] garage)
        {
            return FIndByBody(garage, "Car");
        }

        /// <summary>
        /// Method searching all electric machines in incoming garage.
        /// </summary>
        /// <param name="garage">Incoming garage.</param>
        /// <returns>Array of electric machines.</returns>
        public static ICar[] GetAllElectricMachines(this ICar[] garage)
        {
            int resultLength = 0;
            foreach (var car in garage)
            {
                if (car is AbstractElectricCar)
                {
                    resultLength++;
                }
            }

            ICar[] result = new AbstractCar[resultLength];
            int j = 0;
            for (int i = 0; i < garage.Length; i++)
            {
                if (garage[i] is AbstractElectricCar)
                {
                    result[j] = garage[i];
                    j++;
                }
            }

            return result;
        }

        /// <summary>
        /// Method searching all fuel machines in incoming garage.
        /// </summary>
        /// <param name="garage">Incoming garage.</param>
        /// <returns>Array of fuel machines.</returns>
        public static ICar[] GetAllFuelMachines(this ICar[] garage)
        {
            int resultLength = 0;
            foreach (var car in garage)
            {
                if (car is AbstractFuelCar)
                {
                    resultLength++;
                }
            }

            ICar[] result = new AbstractCar[resultLength];
            int j = 0;
            for (int i = 0; i < garage.Length; i++)
            {
                if (garage[i] is AbstractFuelCar)
                {
                    result[j] = garage[i];
                    j++;
                }
            }

            return result;
        }

        /// <summary>
        /// Method search all machines by incoming body.
        /// </summary>
        /// <param name="garage">Incoming garage.</param>
        /// <param name="body">Incoming body.</param>
        /// <returns>Array of machines with incoming body.</returns>
        private static ICar[] FIndByBody(ICar[] garage, string body)
        {
            int resultLength = 0;
            foreach (var car in garage)
            {
                if (car.Body == body)
                {
                    resultLength++;
                }
            }

            ICar[] result = new AbstractCar[resultLength];
            int j = 0;
            for (int i = 0; i < garage.Length; i++)
            {
                if (garage[i].Body == body)
                {
                    result[j] = garage[i];
                    j++;
                }
            }

            return result;
        }
    }
}
