using HumanResources.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.EntityTypeConfiguration.EntityConfiguration
{
    public class SpentConfig : BaseEntityConfig<Spent>
    {
        public override void Configure(EntityTypeBuilder<Spent> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Accept).IsRequired(false);

            builder.HasOne(x => x.Personnelle)
                .WithMany(x => x.Spents)
                .HasForeignKey(x => x.PersonnelleId);

            base.Configure(builder);
        }
    }
}
