using System;
using System.Collections.Generic;
using System.Text;
using TesteHBSIS.ForecastSln.Domain.Entities;
using TesteHBSIS.ForecastSln.Domain.Interfaces;
using TesteHBSIS.ForecastSln.Infra.Contexts;

namespace TesteHBSIS.ForecastSln.Infra.Repositories
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        public CityRepository(ForecastContext context) : base(context)
        {             
        }
    }
}
