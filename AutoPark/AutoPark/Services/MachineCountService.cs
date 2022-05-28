using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;
using AutoPark.Enums;
using AutoPark.Models.Engins;

namespace AutoPark.Services
{
    internal class MachineCountService : IMachineCountService
    {
        public int CountCoast(string name, string body, int enginePower)
        {
            return CoastVariantByName(name) * VariantByBody(body) * VariantByEnginePower(enginePower);
        }

        public int CountResourseConsumption(string body, int enginePower)
        {
            return VariantByBody(body) * VariantByEnginePower(enginePower);
        }

        public int CountResourseVolume(string body, IEngine engine)
        {
            if (engine is ElectricCarEngine)
            {
                return 2 * VariantByBody(body);
            }
            else if (engine is ElectricTruckEngine)
            {
                return 4 * VariantByBody(body);
            }
            else if (engine is FuelCarEngine)
            {
                return 3 * VariantByBody(body);
            }
            else
            {
                return 5 * VariantByBody(body);
            }
        }

        private int CoastVariantByName(string name)
        {
            int result = 0;
            switch (name)
            {
                case "Audi":
                    result = 2;
                    break;
                case "Mercedes":
                    result = 4;
                    break;
                case "BMW":
                    result = 3;
                    break;
                case "Renault":
                    result = 1;
                    break;
            }

            return result;
        }

        private int VariantByBody(string body)
        {
            int result = 0;
            switch (body)
            {
                case "Car":
                    result = 2;
                    break;
                case "Truck":
                    result = 4;
                    break;
            }

            return result;
        }

        private int VariantByEnginePower(int power)
        {
            int result = 0;
            switch (power)
            {
                case 100:
                    result = 1;
                    break;
                case 150:
                    result = 2;
                    break;
                case 200:
                    result = 3;
                    break;
                case 250:
                    result = 4;
                    break;
            }

            return result;
        }
    }
}
