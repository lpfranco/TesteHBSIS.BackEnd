using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TesteHBSIS.ForecastSln.Application.Applications;
using TesteHBSIS.ForecastSln.Application.Interfaces;
using TesteHBSIS.ForecastSln.Domain.Interfaces;
using TesteHBSIS.ForecastSln.Infra.Contexts;
using TesteHBSIS.ForecastSln.Infra.UnitOfWork;

namespace TesteHBSIS.ForecastSln.IoC
{
    public class DependencyInjector
    {
        public static void Inject(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICityApplication, CityApplication>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<ForecastContext>(options => options.UseSqlServer(configuration.GetConnectionString("ForecastConnection")));
        }
    }
}
