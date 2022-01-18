using System;
using System.Linq;
using WebApplication.Controllers;
using Xunit;
using Xunit.Abstractions;

namespace TestProject1
{
    public class UnitTest1
    {
        private ITestOutputHelper logger;

        public UnitTest1(ITestOutputHelper logger)
        {
            this.logger = logger;
        }

        [Fact]
        public void Test1()
        {
            var controller = new WeatherForecastController(null);
            var data = controller.Get();
            int expected = 5;
            int actual = data.Count();
            Assert.Equal(expected, actual);
            
        }
    }
}