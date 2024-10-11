using Microsoft.VisualStudio.TestTools.UnitTesting;
using YNVRTemperature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YNVRTemperature.Tests
{
    [TestClass()]
    public class TemperaturaTests
    {
            [TestMethod]
            public void CelsiusToFarenheit_ShouldReturnCorrectSum()
            {
                Temperatura temp = new Temperatura();
                double celsius = 35;
                double farenheit = 95;

                double result = temp.CelsiusToFahrenheit(celsius, farenheit);

            Assert.AreEqual(95, result);
            }

            [TestMethod]
            public void FarenheitToCelsius_ShouldReturnCorrectSum()
            {
                Temperatura temp = new Temperatura();
                double celsius = 35;
                double farenheit = 95;

                double result = temp.FahrenheitToCelsius(farenheit, celsius);

                Assert.AreEqual(35, result);
            }
        }

   
}

