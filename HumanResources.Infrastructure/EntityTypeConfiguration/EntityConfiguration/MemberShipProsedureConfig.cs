using HumanResources.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.EntityTypeConfiguration.EntityConfiguration
{
    public class MemberShipProsedureConfig : BaseEntityConfig<MemberShipProsedure>
    {
        public override void Configure(EntityTypeBuilder<MemberShipProsedure> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Accept).IsRequired(false);

            builder.HasOne(x => x.Director)
                .WithOne(x => x.MemberShipProsedure)
                .HasForeignKey<MemberShipProsedure>(x => x.DirectorId);

            base.Configure(builder);
        }
    }
}
