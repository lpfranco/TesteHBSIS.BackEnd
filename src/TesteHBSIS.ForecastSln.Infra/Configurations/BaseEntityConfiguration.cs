using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteHBSIS.ForecastSln.Domain.Entities;

namespace TesteHBSIS.ForecastSln.Infra.Configurations
{
    public class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedOn);
            builder.Property(x => x.UpdatedOn);
        }
    }
}
