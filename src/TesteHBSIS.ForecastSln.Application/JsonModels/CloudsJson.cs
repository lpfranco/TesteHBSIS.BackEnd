using Newtonsoft.Json;

namespace TesteHBSIS.ForecastSln.Application.JsonModels
{
    public class CloudsJson
    {
        [JsonProperty("all")]
        public int CloudsPercentual { get; set; }
    }
}
