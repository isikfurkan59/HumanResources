using HumanResources.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.EntityTypeConfiguration.EntityConfiguration
{
    public class DirectorConfig : BaseEntityConfig<Director>
    {
        public override void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ImagePath).IsRequired(false);
            builder.Property(x => x.Salary).HasPrecision(18, 2);

            base.Configure(builder);
        }
    }
}
