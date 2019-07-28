using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using TesteHBSIS.ForecastSln.Application.JsonModels;
using AutoMapper;

namespace TesteHBSIS.ForecastSln.Application.WeatherApi
{
    public class WeeatherApiConsumer
    {
        private const string APPID = "89a31c90e5ebeb6d57a455f967e6cab7";
        private IMapper _mapper;
        public string CityName { get; private set; }

        public WeeatherApiConsumer(string cityName, IMapper mapper)
        {
            CityName = cityName;
            _mapper = mapper;
        }

        public async Task<RootJson> GetData()
        {
            var url = $@"http://api.openweathermap.org/data/2.5/forecast?q={CityName}&mode=json&units=metric&lang=pt&appid={APPID}";
            var obj = new RootJson();

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(url))
                {
                    using (HttpContent content = res.Content)
                    {
                        var data = await content.ReadAsStringAsync();
                        if (data != null)
                            obj = JsonConvert.DeserializeObject<RootJson>(data);
                        return obj;
                    }
                }
            }
        }

        public async Task<List<FullForecast>> GetFormatedData()
        {
            var data = await GetData();
            if (data.Cod != 200)
                return new List<FullForecast>();

            return _mapper.Map<List<FullForecast>>(data);
        }

    }
}
