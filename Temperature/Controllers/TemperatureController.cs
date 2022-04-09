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
        public KelvinFarenheit CalculateKelvinFarenheit(int tempc)
        {
          return _temperatureService.CalcFarenheitKelvin(tempc);    
        }
    }
}
