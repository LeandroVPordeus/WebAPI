using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2", "valor3" };
        }
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "valor" + id.ToString();
        }
        


        [HttpGet("pessoas")]
        public ActionResult<IEnumerable<Pessoa>> GetPessoas()
        {
            return new[] {
                new Pessoa {Nome = "Tobias"},  
                new Pessoa {Nome = "Jonas"},
                new Pessoa {Nome = "Paulo"},
                new Pessoa {Nome = "Luan"}
                };
        }
        
       
    }
    public class Pessoa
    {
        public string Nome { get; set; }
    }
}
