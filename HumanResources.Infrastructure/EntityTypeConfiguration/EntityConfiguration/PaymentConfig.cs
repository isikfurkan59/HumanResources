using HumanResources.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.EntityTypeConfiguration.EntityConfiguration
{
    public class PaymentConfig : BaseEntityConfig<Payment>
    {
        public override void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PaymentName).IsRequired();
            builder.Property(x => x.Description).IsRequired();

            builder.HasOne(x => x.Director)
                .WithMany(x => x.Payments)
                .HasForeignKey(x => x.DirectorId);

            base.Configure(builder);
        }
    }
}
