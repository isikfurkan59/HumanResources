using HumanResources.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.EntityTypeConfiguration.EntityConfiguration
{
    public class TurnOfWorkConfig : BaseEntityConfig<TurnOfWork>
    {
        public override void Configure(EntityTypeBuilder<TurnOfWork> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TurnOfWorkName).IsRequired();

            builder.HasOne(x => x.Personnelle)
                .WithMany(x => x.TurnOfWorks)
                .HasForeignKey(x => x.PersonnelleId);

            base.Configure(builder);
        }
    }
}
