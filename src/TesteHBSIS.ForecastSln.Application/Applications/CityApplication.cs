using AutoMapper;
using System;
using System.Collections.Generic;
using TesteHBSIS.ForecastSln.Application.DTOs;
using TesteHBSIS.ForecastSln.Application.Interfaces;
using TesteHBSIS.ForecastSln.Application.WeatherApi;
using TesteHBSIS.ForecastSln.Domain.Entities;
using TesteHBSIS.ForecastSln.Domain.Interfaces;

namespace TesteHBSIS.ForecastSln.Application.Applications
{
    public class CityApplication : ICityApplication
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public CityApplication(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public bool Include(CityDTO city)
        {
            _unitOfWork.CityRepository.Add(_mapper.Map<City>(city));
            return _unitOfWork.Commit();
        }

        public bool Update(CityDTO city)
        {
            _unitOfWork.CityRepository.Update(_mapper.Map<City>(city));
            return _unitOfWork.Commit();
        }

        public bool Remove(Guid id)
        {
            var city = _unitOfWork.CityRepository.GetById(id);
            if (city != null)
                _unitOfWork.CityRepository.Remove(id);

            return _unitOfWork.Commit();
        }

        public IEnumerable<CityDTO> GetAll()
        {
            var cities = _unitOfWork.CityRepository.GetAll();
            return _mapper.Map<IEnumerable<CityDTO>>(cities);
        }

        public IEnumerable<FullForecast> GetWeatherForecast(string city)
        {
            var apiConsumer = new WeeatherApiConsumer(city, _mapper);
            return apiConsumer.GetFormatedData().GetAwaiter().GetResult();
        }
    }
}
