using MyApi;

namespace ApiTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var service=new WeatherService();
            var today=service.GetTodayWeather();
            Assert.Equal("rain", today);
        }
    }
}