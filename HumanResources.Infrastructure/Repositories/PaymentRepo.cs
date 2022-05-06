using HumanResources.Domain.Entities;
using HumanResources.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.Repositories
{
    public class PaymentRepo : BaseRepository<Payment>, IPaymentRepo
    {
        private readonly AppDbContext db;

        public PaymentRepo(AppDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
