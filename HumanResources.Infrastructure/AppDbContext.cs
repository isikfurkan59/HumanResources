using HumanResources.Domain.Entities;
using HumanResources.Infrastructure.EntityTypeConfiguration.EntityConfiguration;
using HumanResources.Infrastructure.EntityTypeConfiguration.UserConfiguration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Debit> Debits { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<FlexDay> FlexDays { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<MemberShipProsedure> MemberShipProsedures { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Personnelle> Personnelles { get; set; }
        public DbSet<Spent> Spents { get; set; }
        public DbSet<TurnOfWork> TurnOfWorks { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CommentConfig());
            builder.ApplyConfiguration(new CompanyConfig());
            builder.ApplyConfiguration(new DebitConfig());
            builder.ApplyConfiguration(new FlexDayConfig());
            builder.ApplyConfiguration(new HolidayConfig());
            builder.ApplyConfiguration(new MemberShipProsedureConfig());
            builder.ApplyConfiguration(new PaymentConfig());
            builder.ApplyConfiguration(new SpentConfig());
            builder.ApplyConfiguration(new TurnOfWorkConfig());
            builder.ApplyConfiguration(new AppUserConfig());
            builder.ApplyConfiguration(new PersonnelleConfig());
            base.OnModelCreating(builder);
        }
    }
}
