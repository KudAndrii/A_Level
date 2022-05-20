using System;
using Zoo.Models;
using Zoo.Enums;
using Zoo.AbstractAnimals;
using Zoo.Extensions;

namespace Zoo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ZooServices zooServices = new ZooServices(new Random());
            ICreature[] zoo = zooServices.GenerateZoo(10);
            zooServices.MakeAllEat(zoo);
            ICreature[] hunters = zoo.GetAllHunters();
            ICreature[] herbivores = zoo.GetAllHerbivores();
            zooServices.MakeAllScream(hunters);
            zooServices.MakeAllScream(herbivores);
        }
    }
}
