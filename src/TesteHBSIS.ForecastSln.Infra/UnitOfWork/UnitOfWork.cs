using TesteHBSIS.ForecastSln.Domain.Interfaces;
using TesteHBSIS.ForecastSln.Infra.Contexts;
using TesteHBSIS.ForecastSln.Infra.Repositories;

namespace TesteHBSIS.ForecastSln.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ForecastContext _context;
        private ICityRepository _cityRepository;

        public UnitOfWork(ForecastContext context)
        {
            _context = context;
        }

        public ICityRepository CityRepository
        {
            get
            {
                if (_cityRepository == null)
                    _cityRepository = new CityRepository(_context);
                return _cityRepository;
            }
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
