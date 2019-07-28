using Newtonsoft.Json;

namespace TesteHBSIS.ForecastSln.Application.JsonModels
{
    public class WeatherJson
    {
        [JsonProperty("main")]
        public string WeatherGroupParemeters { get; set; }
        [JsonProperty("description")]
        public string WeatherCondition { get; set; }
    }
}
