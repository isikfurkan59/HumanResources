using HumanResources.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.EntityTypeConfiguration.EntityConfiguration
{
    public class DebitConfig : BaseEntityConfig<Debit>
    {
        public override void Configure(EntityTypeBuilder<Debit> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DebitName).IsRequired();
            builder.Property(x => x.Accept).IsRequired(false);

            builder.HasOne(x => x.Personnelle)
                .WithMany(x => x.Debits)
                .HasForeignKey(x => x.PersonnelleId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Director)
                .WithMany(x => x.Debits)
                .HasForeignKey(x => x.DirectorId).OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}
