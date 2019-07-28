using Newtonsoft.Json;
using System.Collections.Generic;

namespace TesteHBSIS.ForecastSln.Application.JsonModels
{
    public class RootJson
    {
        [JsonProperty("list")]
        public List<ForecastJson> Forecasts { get; set; }
        [JsonProperty("city")]
        public CityJson City { get; set; }
        [JsonProperty("cod")]
        public int Cod { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
