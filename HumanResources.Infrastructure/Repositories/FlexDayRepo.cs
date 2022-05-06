using HumanResources.Domain.Entities;
using HumanResources.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.Repositories
{
    public class FlexDayRepo : BaseRepository<FlexDay>, IFlexDayRepo
    {
        private readonly AppDbContext db;

        public FlexDayRepo(AppDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
