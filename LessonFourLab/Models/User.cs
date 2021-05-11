using Newtonsoft.Json;

namespace LessonFourLab.Model
{
    public class User
    {
        [JsonProperty(PropertyName = "login")]
        public string userName { get; set; }

        public override string ToString()
        {
            return userName;
        }
    }
}