using System.Threading.Tasks;

namespace Temperature.Interfaces
{
    public interface ICalculateTemperatureService
    {
        double CalculateTemperature(int tempC, string convertParam);
    }
}
