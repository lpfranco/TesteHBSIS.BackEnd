using AutoMapper;
namespace TesteHBSIS.ForecastSln.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration Configure()
        {
            return new MapperConfiguration(cfg => 
            {
                cfg.AddProfile(new EntityToDTOProfile());
                cfg.AddProfile(new DTOToEntityProfile());
                cfg.AddProfile(new RootJsonToFullForecast());
            });
        }
    }
}
