using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TesteHBSIS.ForecastSln.Application.DTOs;
using TesteHBSIS.ForecastSln.Domain.Entities;

namespace TesteHBSIS.ForecastSln.Application.AutoMapper
{
    internal class EntityToDTOProfile : Profile
    {
        public EntityToDTOProfile()
        {
            CreateMap<City, CityDTO>();
        }
    }
}
