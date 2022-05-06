using HumanResources.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.EntityTypeConfiguration.UserConfiguration
{
    public abstract class UserEntityConfig<T> : IEntityTypeConfiguration<T> where T : class, IUser
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.Gender).IsRequired(false);
        }
    }
}
