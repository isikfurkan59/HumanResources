using HumanResources.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.EntityTypeConfiguration.EntityConfiguration
{
    public class CompanyConfig : BaseEntityConfig<Company>
    {
        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CompanyName).IsRequired();
            builder.Property(x => x.Sector).IsRequired();
            builder.Property(x => x.LogoPath).IsRequired(false);

            builder.HasOne(x => x.Director)
                .WithOne(x => x.Company)
                .HasForeignKey<Company>(x => x.DirectorId);

            base.Configure(builder);
        }
    }
}
