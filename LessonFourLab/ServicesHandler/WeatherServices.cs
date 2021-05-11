using LessonFourLab.Models;
using LessonFourLab.WeatherRestClient;
using LessonFourLab.Models;
using System.Threading.Tasks;

namespace LessonFourLab.ServicesHandler
{
    public class WeatherServices
    {
        OpenWeatherMap<WeatherMainModel> _openWeatherRest = new OpenWeatherMap<WeatherMainModel>();
        public async Task<WeatherMainModel> GetWeatherDetails(string city)
        {
            var getWeatherDetails = await _openWeatherRest.GetAllWeathers(city);
            return getWeatherDetails;
        }
    }
}