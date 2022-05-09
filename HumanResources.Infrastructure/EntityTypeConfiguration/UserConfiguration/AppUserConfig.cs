using HumanResources.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.EntityTypeConfiguration.UserConfiguration
{
    public class AppUserConfig : UserEntityConfig<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {

            builder.HasOne(x => x.Personnelle).WithOne(x => x.AppUser).
                HasForeignKey<AppUser>(x => x.PersonnelleId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Director).WithOne(x => x.AppUser).HasForeignKey<AppUser>(x => x.DirectorId)
                .OnDelete(DeleteBehavior.Cascade);

            base.Configure(builder);
        }
    }
}
