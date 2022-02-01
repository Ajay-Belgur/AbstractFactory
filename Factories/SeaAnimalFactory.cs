using AbstractFactory.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class SeaAnimalFactory : AnimalFactory
    {

        public override IAnimal GetAnimal(string animalName)
        {
            if ("duck".Equals(animalName, StringComparison.OrdinalIgnoreCase))
                return new Duck();
            else
                return new Whale(); throw new NotImplementedException();
        }
    }
}
