using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteHBSIS.ForecastSln.Domain.Entities;

namespace TesteHBSIS.ForecastSln.Infra.Configurations
{
    public class CityConfiguration : BaseEntityConfiguration<City>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.CityName);
        }
    }
}
