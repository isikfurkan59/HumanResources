using HumanResources.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.EntityTypeConfiguration.UserConfiguration
{
    public class AdminConfig : UserEntityConfig<Admin>
    {
        public override void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(new Admin() { Id = 1, FirstName = "Admin", LastName = "Admin", Address = "Admin", City = "Admin", Country = "Admin", Email = "Admin", Password = "123456789", Gender = true });

            base.Configure(builder);


        }
    }
}
