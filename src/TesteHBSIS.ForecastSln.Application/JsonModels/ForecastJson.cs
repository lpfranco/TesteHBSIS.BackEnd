using Newtonsoft.Json;
using System.Collections.Generic;

namespace TesteHBSIS.ForecastSln.Application.JsonModels
{
    public class ForecastJson
    {
        [JsonProperty("dt")]
        public int DateTimeUnix { get; set; }
        [JsonProperty("main")]
        public MainInformationJson MainInformation { get; set; }
        [JsonProperty("weather")]
        public List<WeatherJson> Weather { get; set; }
        [JsonProperty("clouds")]
        public CloudsJson Clouds { get; set; }
        [JsonProperty("wind")]
        public WindJson Wind { get; set; }
        [JsonProperty("dt_txt")]
        public string FormatedDateTime { get; set; }
    }
}
