using System;
using Temperature.Interfaces;

namespace Temperature.Services
{
    public class TemperatureService : ICalculateTemperatureService
    {
        public double CalculateTemperature(int tempC, string convert)
        {
            switch (convert)
            {
                case "ck":
                    return tempC + 273.15;
                case "cf":
                    return Math.Round((tempC * 1.8) + 32, 2);
                case "kc":
                    return tempC - 273.15;
                case "kf":
                    return Math.Round(1.8 * (tempC - 273.15) + 32, 2);
                case "fc":
                    return Math.Round((tempC - 32) / 1.8, 2);
                case "fk":
                    return Math.Round((tempC + 459.67) * (5 / 9), 2);
                case "rc":
                    return Math.Round((tempC - 7.5) / 0.525, 2);
                case "cr":
                    return Math.Round(tempC * 0.525 + 7.5, 2);
                case "fr":
                    return Math.Round((tempC - 32)*0.29167 + 7.50, 2);
                case "rf":
                    return Math.Round((tempC - 7.5) * 3.4286 + 32.00, 2);
                default:
                    throw new Exception("Use non-existing convert parameter");
            }


        }
    }
}
