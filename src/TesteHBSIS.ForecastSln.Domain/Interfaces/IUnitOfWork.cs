using System;

namespace TesteHBSIS.ForecastSln.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICityRepository CityRepository { get; }
        bool Commit();
    }
}
