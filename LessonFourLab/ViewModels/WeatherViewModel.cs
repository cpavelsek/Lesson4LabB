using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using LessonFourLab.Models;
using LessonFourLab.ServicesHandler;
using LessonFourLab.WeatherRestClient;


namespace LessonFourLab.ViewModels
{
    public class WeatherViewModel : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private async Task InitializeGetWeatherAsync()
        {
            try
            {
                IsBusy = true; // set the ui property "IsRunning" to true(loading) in Xaml ActivityIndicator Control
                WeatherMainModel = await _weatherServices.GetWeatherDetails(_city);
            }
            finally
            {
                IsBusy = false;
            }
        }


        WeatherServices _weatherServices = new WeatherServices();

        private WeatherMainModel _weatherMainModel;  // for xaml binding

        public bool IsBusy { get; private set; }

        public WeatherMainModel WeatherMainModel
        {
            get { return _weatherMainModel; }
            set
            {
                _weatherMainModel = value;
                IconImageString = "http://openweathermap.org/img/w/" + _weatherMainModel.weather[0].icon + ".png"; // fetch weather icon image
                OnPropertyChanged();
            }
        }

        private string _city;   // for entry binding and for method parameter value
        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                Task.Run(async () => {
                    await InitializeGetWeatherAsync();
                });
                OnPropertyChanged();
            }
        }

        private string _iconImageString; // for weather icon image string binding
        public string IconImageString
        {
            get { return _iconImageString; }
            set
            {
                _iconImageString = value;
                OnPropertyChanged();
            }
        }
    }


 }

