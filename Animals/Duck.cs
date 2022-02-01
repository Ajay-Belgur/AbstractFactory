using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Animals
{
    public class Duck : IAnimal
    {
        public string GetSound()
        {
            return "Squack";
        }
    }
}
