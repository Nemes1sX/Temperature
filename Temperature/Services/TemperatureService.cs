using System.Threading.Tasks;
using Temperature.Interfaces;

namespace Temperature.Services
{
    public class TemperatureService : ICalculateTemperatureService
    {
        public object CalcFarenheitKelvin(int tempC)
        {
            var temps = new 
            {
                Kelvin = tempC + 273.15,
                Farenheit = (tempC * 1.8) + 32
            };

            return temps;
        }
    }
}
