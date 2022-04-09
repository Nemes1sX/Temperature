using System.Threading.Tasks;
using Temperature.Models;

namespace Temperature.Interfaces
{
    public interface ICalculateTemperatureService
    {
        KelvinFarenheit CalcFarenheitKelvin(int tempC);
    }
}
