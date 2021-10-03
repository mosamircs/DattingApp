using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DatingApp.Controllers
{//.net5
    [ApiController]
    [Route("[controller]")]
    public class MyDataController : ControllerBase
    {
        private static readonly string[] Abilties = new[]
        {
            ".Net","C#","HTML","CSS","JavaScript","Algorithms","DataStructures","OOP","DesignPatterns","SOLID"
        };
        private static readonly string[] Name = new[]
        {
            "Moahemd","Samir","test1","test2"
        };
        private readonly ILogger<MyDataController> _logger;

        public MyDataController(ILogger<MyDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]//End point 
        //that we get when HTTP GET request data from API Server
        public IEnumerable<MyData> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new MyData
            {
                Name = "Mohamed Samir",
                YearOfBirth = 1996,
                Abilties = Abilties[rng.Next(Abilties.Length)]
            })
            .ToArray();
        }
    }
}
