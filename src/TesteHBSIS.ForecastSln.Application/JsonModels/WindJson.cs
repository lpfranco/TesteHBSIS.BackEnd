using Newtonsoft.Json;

namespace TesteHBSIS.ForecastSln.Application.JsonModels
{
    public class WindJson
    {
        [JsonProperty("speed")]
        public double WindSpeed { get; set; }
        [JsonProperty("deg")]
        public double WindDegree { get; set; }
    }
}
