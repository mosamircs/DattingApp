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
            "Moahemd","Samir","amin","test2"
        };
        private static readonly int [] YearOfBirth=new []
        {
            1997,1996,1967,2000
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
                Name = Name[rng.Next(Name.Length)],
                YearOfBirth = YearOfBirth[rng.Next(YearOfBirth.Length)],
                Abilties = Abilties[rng.Next(Abilties.Length)]
            })
            .ToArray();
        }
    }
}
