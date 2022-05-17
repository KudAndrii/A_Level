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
            ZooServices zooServices = new ZooServices();
            Creature[] zoo = zooServices.GenerateZoo(10);
            zooServices.MakeAllEat(zoo);
            Creature[] hunters = zoo.GetAllHunters();
            Creature[] herbivores = zoo.GetAllHerbivores();
            zooServices.MakeAllScream(hunters);
            zooServices.MakeAllScream(herbivores);
        }
    }
}
