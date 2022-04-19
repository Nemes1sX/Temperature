using System.Threading.Tasks;

namespace Temperature.Interfaces
{
    public interface ICalculateTemperatureService
    {
        double CalculateTemperature(double tempC, string convertParam);
    }
}
