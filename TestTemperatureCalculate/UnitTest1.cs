using System;
using Temperature.Services;
using Xunit;

namespace TestTemperatureCalculate
{
    public class UnitTest1
    {
        private TemperatureService _temperatureService;

        public UnitTest1()
        {
            _temperatureService = new TemperatureService();
        }

        [Fact]
        public void Test1()
        {
            var data = _temperatureService.CalcFarenheitKelvin(0);

            Assert.Equal(273.15, data.Kelvin);
            Assert.Equal(32, data.Farenheit);
        }
    }
}
