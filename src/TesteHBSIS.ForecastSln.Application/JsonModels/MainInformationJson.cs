using Newtonsoft.Json;

namespace TesteHBSIS.ForecastSln.Application.JsonModels
{
    public class MainInformationJson
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }
        [JsonProperty("temp_min")]
        public double MinTemperature { get; set; }
        [JsonProperty("temp_max")]
        public double MaxTemperature { get; set; }
        [JsonProperty("humidity")]
        public int HumidityPercent { get; set; }
    }
}
