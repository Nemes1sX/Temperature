using System.Threading.Tasks;
using Temperature.Interfaces;
using Temperature.Models;

namespace Temperature.Services
{
    public class TemperatureService : ICalculateTemperatureService
    {
        public KelvinFarenheit CalcFarenheitKelvin(int tempC)
        {
            var temps = new KelvinFarenheit()
            {
                Kelvin = tempC + 273.15,
                Farenheit = (tempC * 1.8) + 32
            };

            return temps;
        }
    }
}
