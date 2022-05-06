using HumanResources.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.EntityTypeConfiguration.UserConfiguration
{
    public class PersonnelleConfig : UserEntityConfig<Personnelle>
    {
        public override void Configure(EntityTypeBuilder<Personnelle> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Salary).HasPrecision(18, 2);

            builder.HasOne(x => x.Director).WithMany(x => x.Personnelles).HasForeignKey(x => x.DirectorId);

            base.Configure(builder);
        }
    }
}
