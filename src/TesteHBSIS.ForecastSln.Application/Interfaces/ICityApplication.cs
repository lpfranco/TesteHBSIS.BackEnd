using System;
using System.Collections.Generic;
using System.Text;
using TesteHBSIS.ForecastSln.Application.DTOs;
using TesteHBSIS.ForecastSln.Application.WeatherApi;


namespace TesteHBSIS.ForecastSln.Application.Interfaces
{
    public interface ICityApplication
    {
        bool Include(CityDTO city);
        bool Update(CityDTO city);
        bool Remove(Guid city);
        IEnumerable<CityDTO> GetAll();
        IEnumerable<FullForecast> GetWeatherForecast(string city);
    }
}
