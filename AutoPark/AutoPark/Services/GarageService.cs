using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;
using AutoPark.Models.Cars;
using AutoPark.Enums;
using AutoPark.Abstractions;

namespace AutoPark.Services
{
    internal class GarageService : IGarageService
    {
        private readonly IMachineCountService _machineCountService;
        private readonly IEngineFactory _engineFactory;
        private readonly Random _random;
        public GarageService(IMachineCountService machineCountService, IEngineFactory engineFactory, Random random)
        {
            _machineCountService = machineCountService;
            _engineFactory = engineFactory;
            _random = random;
        }

        public int CountCoast(ICar[] garage)
        {
            int result = 0;
            foreach (var car in garage)
            {
                result += car.Coast;
            }

            return result;
        }

        public ICar[] GenerateGarage(int machineCount)
        {
            ICar[] result = new AbstractCar[machineCount];
            for (int i = 0; i < result.Length; i++)
            {
                switch (_random.Next(0, 4))
                {
                    case 0:
                        result[i] = new ElectricCar(_machineCountService, _engineFactory, (Names)_random.Next(0, 4), Bodys.Car);
                        break;
                    case 1:
                        result[i] = new ElectricTruck(_machineCountService, _engineFactory, (Names)_random.Next(0, 4), Bodys.Truck);
                        break;
                    case 2:
                        result[i] = new FuelCar(_machineCountService, _engineFactory, (Names)_random.Next(0, 4), Bodys.Car);
                        break;
                    case 3:
                        result[i] = new FuelTruck(_machineCountService, _engineFactory, (Names)_random.Next(0, 4), Bodys.Truck);
                        break;
                }
            }

            return result;
        }

        public ICar[] SortByResourseConsumption(ICar[] garage)
        {
            for (int i = 0; i < garage.Length - 1; i++)
            {
                for (int j = i + 1; j < garage.Length; j++)
                {
                    if (garage[i].ResourseConsumption > garage[j].ResourseConsumption)
                    {
                        var k = garage[i];
                        garage[i] = garage[j];
                        garage[j] = k;
                    }
                }
            }

            return garage;
        }
    }
}
