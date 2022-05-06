using HumanResources.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.EntityTypeConfiguration.EntityConfiguration
{
    public class FlexDayConfig : BaseEntityConfig<FlexDay>
    {
        public override void Configure(EntityTypeBuilder<FlexDay> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Accept).IsRequired(false);

            builder.HasOne(x => x.Personnelle)
                .WithMany(x => x.FlexDays)
                .HasForeignKey(x => x.PersonnelleId);

            base.Configure(builder);
        }
    }
}
