using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteHBSIS.ForecastSln.Application.JsonModels;
using TesteHBSIS.ForecastSln.Application.WeatherApi;

namespace TesteHBSIS.ForecastSln.Application.AutoMapper
{
    internal class RootJsonToFullForecast : Profile
    {
        public RootJsonToFullForecast()
        {
            CreateMap<RootJson, List<FullForecast>>().ConstructUsing(root =>
            {
                var lstFullForecast = new List<FullForecast>();
                foreach (var forecast in root.Forecasts)
                {
                    var fullForecast = new FullForecast();
                    fullForecast.City = root.City.CityName;
                    fullForecast.DateTimeForecast = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(forecast.DateTimeUnix).ToLocalTime();
                    fullForecast.Temperature = forecast.MainInformation.Temperature;
                    fullForecast.MinTemperature = forecast.MainInformation.MinTemperature;
                    fullForecast.MaxTemperature = forecast.MainInformation.MaxTemperature;
                    fullForecast.Humidity = forecast.MainInformation.HumidityPercent;
                    fullForecast.Description = forecast.Weather.FirstOrDefault().WeatherGroupParemeters + " / " + forecast.Weather.FirstOrDefault().WeatherCondition;
                    fullForecast.WindSpeed = forecast.Wind.WindSpeed;
                    fullForecast.WindDegree = forecast.Wind.WindDegree;

                    lstFullForecast.Add(fullForecast);
                };
                return lstFullForecast;
            });    
        }
    }
}
