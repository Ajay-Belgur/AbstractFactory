using AbstractFactory.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalName)
        {
            if ("cat".Equals(animalName, StringComparison.OrdinalIgnoreCase))
                return new Cat();

            else
                return new Dog();
        }
    }
}
