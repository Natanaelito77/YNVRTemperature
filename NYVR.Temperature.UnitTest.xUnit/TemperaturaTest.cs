using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YNVRTemperature;

namespace NYVR.Temperature.UnitTest.xUnit
{
    public class TemperaturaTest
    {
            [Fact]
            public void CelsiusToFarenheit_ShouldReturnCorrectSum()
            {
                Temperatura temp = new Temperatura();
                double celsius = 35;
                double farenheit = 95;

                double result = temp.CelsiusToFahrenheit(celsius, farenheit);

                Assert.Equal(95, result);
            }

            [Fact]
            public void FarenheitToCelsius_ShouldReturnCorrectSum()
            {
                Temperatura temp = new Temperatura();
                double celsius = 35;
                double farenheit = 95;

                double result = temp.FahrenheitToCelsius(farenheit, celsius);

                Assert.Equal(35, result);
            }
        }
    }



