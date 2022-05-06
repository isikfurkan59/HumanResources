using HumanResources.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.EntityTypeConfiguration.EntityConfiguration
{
    public class CommentConfig : BaseEntityConfig<Comment>
    {
        public override void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Content).IsRequired();

            builder.HasOne(x => x.Director)
                .WithOne(x => x.Comment)
                .HasForeignKey<Comment>(x => x.DirectorId);

            base.Configure(builder);
        }
    }
}
