using System;

namespace TesteHBSIS.ForecastSln.Domain.Entities
{
    public class City : BaseEntity
    {
        public string CityName { get; private set; }

        public City(string cityName)
        {
            Id = new Guid();
            CityName = cityName;
        }
    }
}
