using JekinsWebAppSample.Controllers;

namespace TestProject1
{
    public class UnitTest1
    {
        WeatherForecastController forcast = new WeatherForecastController();
        [Fact]
        public void DoesListContain()
        {
            var list = forcast.Get().ToArray();
            Assert.Contains(list, item => item.Summary == "Bolaji");
        }
    }
}