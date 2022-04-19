using System;
using Temperature.Services;
using TestTemperatureCalculate.Attributes;
using Xunit;

namespace TestTemperatureCalculate
{
    [TestCaseOrderer("TestTemperatureCalculate.Orderers.PriorityOrder", "TestTemperatureCalculate")]
    public class UnitTest1
    {
        private TemperatureService _temperatureService;

        public UnitTest1()
        {
            _temperatureService = new TemperatureService();
        }

        [Fact, TestPriority(1)]
        public void CelsiusKelvin()
        {
            var data = _temperatureService.CalculateTemperature(0, "ck");

            Assert.Equal(273.15, data);
        }

        [Fact, TestPriority(2)]
        public void CelsiusFarenheit()
        {
            var data = _temperatureService.CalculateTemperature(0, "cf");

            Assert.Equal(32, data);
        }

        [Fact, TestPriority(3)]
        public void KelvinCelsius()
        {
            var data = _temperatureService.CalculateTemperature(0, "kc");

            Assert.Equal(-273.15, data);
        }  

        [Fact, TestPriority(4)]
        public void KelvinFrenheit()
        {
            var data = _temperatureService.CalculateTemperature(0, "kf");

            Assert.Equal(-459.67, data);
        }

        [Fact, TestPriority(5)]
        public void FarenheitCelsius()
        {
            var data = _temperatureService.CalculateTemperature(0, "fc");

            Assert.Equal(-17.78, data);
        }
       
        [Fact, TestPriority(6)]
        public void RomerCelsius()
        {
            var data = _temperatureService.CalculateTemperature(0, "rc");

            Assert.Equal(-14.29, data);
        }

        [Fact, TestPriority(7)]
        public void CelsiusRomer()
        {
            var data = _temperatureService.CalculateTemperature(0, "cr");

            Assert.Equal(7.50, data);
        }

        [Fact, TestPriority(8)]
        public void FarenheitRomer()
        {
            var data = _temperatureService.CalculateTemperature(0, "fr");

            Assert.Equal(-1.83, data);
        }

        [Fact, TestPriority(9)]
        public void RomerFarenheit()
        {
            var data = _temperatureService.CalculateTemperature(0, "rf");

            Assert.Equal(6.29, data);
        }

        [Fact, TestPriority(10)]
        public void FarenheitKelvin()
        {
            var data = _temperatureService.CalculateTemperature(0, "fk");

            Assert.Equal(255.37, data);
        }

    }
}
