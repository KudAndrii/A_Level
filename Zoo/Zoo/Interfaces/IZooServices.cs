using Zoo.AbstractAnimals;

namespace Zoo
{
    internal interface IZooServices
    {
        ICreature[] GenerateZoo(int lenght);
        void MakeAllEat(ICreature[] animals);
        void MakeAllScream(ICreature[] zoo);
    }
}