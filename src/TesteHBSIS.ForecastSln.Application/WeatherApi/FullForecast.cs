using System;

namespace TesteHBSIS.ForecastSln.Application.WeatherApi
{
    public class FullForecast
    {
        public string City { get; set; }
        public DateTime DateTimeForecast { get; set; }
        public double Temperature { get; set; }
        public double MaxTemperature { get; set; }
        public double MinTemperature { get; set; }
        public double Humidity { get; set; }
        public string Description { get; set; }
        public double WindSpeed { get; set; }
        public double WindDegree { get; set; }
    }
}
