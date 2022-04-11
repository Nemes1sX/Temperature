using System.Threading.Tasks;
using Temperature.Models;

namespace Temperature.Interfaces
{
    public interface ICalculateTemperatureService
    {
        double CalcFarenheitKelvin(int tempC, string convertParam);
    }
}
