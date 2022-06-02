using System;
using AutoPark.Interfaces;
using AutoPark.Services;
using Microsoft.Extensions.DependencyInjection;
using AutoPark.MyExtensions;

namespace AutoPark
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = new Container();
            var load = container.Load();
            IGarageService garageService = load.GetService<IGarageService>();
            ICar[] garage = garageService.GenerateGarage(10);
            Console.WriteLine("Coast of generated garage: " + garageService.CountCoast(garage));
            garage = garageService.SortByResourseConsumption(garage);
            ICar[] cars = garage.GetAllCars();
            ICar[] trucks = garage.GetAllTrucks();
            ICar[] electricMachines = garage.GetAllElectricMachines();
            ICar[] fuelMachines = garage.GetAllFuelMachines();
        }
    }
}
