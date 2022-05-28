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
        public static ICar[] GetAllTrucks(this ICar[] garage)
        {
            return FIndByBody(garage, "Truck");
        }

        public static ICar[] GetAllCars(this ICar[] garage)
        {
            return FIndByBody(garage, "Car");
        }

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
