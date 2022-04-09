using System.Threading.Tasks;

namespace Temperature.Interfaces
{
    public interface ICalculateTemperatureService
    {
        object CalcFarenheitKelvin(int tempC);
    }
}
