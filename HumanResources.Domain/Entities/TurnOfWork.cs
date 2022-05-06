using HumanResources.Domain.Enums;
using HumanResources.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Domain.Entities
{
    public class TurnOfWork : IDate
    {
        public int Id { get; set; }
        public string TurnOfWorkName { get; set; }

        public DateTime BreakTimeStart { get; set; }
        public DateTime BreakTimeEnd { get; set; }
        public DateTime WorkTimeStart { get; set; }
        public DateTime WorkTimeEnd { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public State State { get; set; }

        //Navigation

        public int PersonnelleId { get; set; }
        public Personnelle Personnelle { get; set; }
    }
}
