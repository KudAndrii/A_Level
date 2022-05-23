using System;
using Zoo.Models;
using Zoo.Enums;
using Zoo.AbstractAnimals;
using Zoo.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Zoo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var config = new Config();
            var container = config.Load();
            IZooServices zooServices = container.GetService<IZooServices>();
            ICreature[] zoo = zooServices.GenerateZoo(10);
            zooServices.MakeAllEat(zoo);
            ICreature[] hunters = zoo.GetAllHunters();
            ICreature[] herbivores = zoo.GetAllHerbivores();
            zooServices.MakeAllScream(hunters);
            zooServices.MakeAllScream(herbivores);
        }
    }
}
