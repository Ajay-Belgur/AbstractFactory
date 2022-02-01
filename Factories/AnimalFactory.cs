using AbstractFactory.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public abstract class AnimalFactory
    {

        public abstract IAnimal GetAnimal(string animalName);

        public static AnimalFactory GetAnimalFactory(string factoryName)
        {
            if ("landanimal".Equals(factoryName, StringComparison.OrdinalIgnoreCase))
                return new LandAnimalFactory();
            else
                return new SeaAnimalFactory();
        }
    }
}
