
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace LessonFourLab.WeatherRestClient
{
    public class OpenWeatherMap<T>
    {
       // const topFilms ='https://api.themoviedb.org/3/movie/top_rated?api_key=22291b84074a8a7ddb5b1547378f77e7&language=en-US&page=1';
       // private const string OpenMovieApi = "https://api.themoviedb.org/3/movie/";
       // private const string Key = "22291b84074a8a7ddb5b1547378f77e7";

        private const string OpenWeatherApi = "http://api.openweathermap.org/data/2.5/weather?q=";
        private const string Key = "653b1f0bf8a08686ac505ef6f05b94c2";


        HttpClient _httpClient = new HttpClient();

        public async Task<T> GetAllWeathers(string city)
        {
            var json = await _httpClient.GetStringAsync(OpenWeatherApi + city + "&APPID=" + Key);
            //var json = await _httpClient.GetStringAsync(OpenMovieApi + city + "&APPID=" + Key);
            var getWeatherModels = JsonConvert.DeserializeObject<T>(json);
            return getWeatherModels;
        }
    }
}
