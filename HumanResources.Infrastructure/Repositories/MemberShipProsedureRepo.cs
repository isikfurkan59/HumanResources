using HumanResources.Domain.Entities;
using HumanResources.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.Repositories
{
    public class MemberShipProsedureRepo : BaseRepository<MemberShipProsedure>, IMemberShipProsedureRepo
    {
        private readonly AppDbContext db;

        public MemberShipProsedureRepo(AppDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
