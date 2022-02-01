using AbstractFactory.Factories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AbstractFactoryController : Controller
    {
       
        [HttpGet]
        [Route("[action]")]
        public IActionResult Get(string animalFactory, string animalName)
        {
            var animalFacotory = AnimalFactory.GetAnimalFactory(animalFactory);
            return Ok(animalFacotory.GetAnimal(animalName).GetSound());
        }
      
    }
}
