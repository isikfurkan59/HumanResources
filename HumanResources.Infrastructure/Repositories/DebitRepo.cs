using HumanResources.Domain.Entities;
using HumanResources.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.Repositories
{
    public class DebitRepo : BaseRepository<Debit>, IDebitRepo
    {
        private readonly AppDbContext db;

        public DebitRepo(AppDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
