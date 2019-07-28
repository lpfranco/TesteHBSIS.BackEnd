using Newtonsoft.Json;

namespace TesteHBSIS.ForecastSln.Application.JsonModels
{
    public class CityJson
    {
        [JsonProperty("name")]
        public string CityName { get; set; }
    }
}
