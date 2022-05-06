using HumanResources.Domain.Entities;
using HumanResources.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.Repositories
{
    public class TurnOfWorkRepo : BaseRepository<TurnOfWork>, ITurnOfWorkRepo
    {
        private readonly AppDbContext db;

        public TurnOfWorkRepo(AppDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
