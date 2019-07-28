using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TesteHBSIS.ForecastSln.Application.DTOs;
using TesteHBSIS.ForecastSln.Domain.Entities;

namespace TesteHBSIS.ForecastSln.Application.AutoMapper
{
    internal class DTOToEntityProfile : Profile
    {
        public DTOToEntityProfile()
        {
            CreateMap<CityDTO, City>().ConstructUsing(c => new City(c.CityName));
        }
    }
}
