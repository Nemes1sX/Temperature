using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Temperature.Interfaces;
using Temperature.Models;

namespace Temperature.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {

        private readonly ICalculateTemperatureService _temperatureService;

        public TemperatureController(ICalculateTemperatureService temperatureService)
        {
            _temperatureService = temperatureService;
        }

        [HttpGet]
        [Route("kelvinfarenheit")]
        public double CalculateKelvinFarenheit(int temp, string convert)
        {
          return _temperatureService.CalcFarenheitKelvin(temp, convert);    
        }
    }
}
