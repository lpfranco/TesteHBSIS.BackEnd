using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteHBSIS.ForecastSln.Application.DTOs;
using TesteHBSIS.ForecastSln.Application.Interfaces;
using TesteHBSIS.ForecastSln.Application.WeatherApi;

namespace TesteHBSIS.ForecastSln.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/City")]
    public class CityController : Controller
    {
        private ICityApplication _cityApplication;
        public CityController(ICityApplication cityApplication)
        {          
            _cityApplication = cityApplication;
        }

        [HttpGet("{city}")]
        [Route("GetForecast")]
        public IEnumerable<FullForecast> GetForecast(string city)
        {
            return _cityApplication.GetWeatherForecast(city);
        }

        [HttpGet]
        public IEnumerable<CityDTO> Get()
        {
            return _cityApplication.GetAll();
        }

        [HttpPost]
        public void Post([FromBody]CityDTO city)
        {
            _cityApplication.Include(city);
        }

        [HttpPut]
        public void Put([FromBody]CityDTO city)
        {
            _cityApplication.Update(city);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _cityApplication.Remove(new Guid(id));
        }

    }
}