using HumanResources.Domain.Enums;
using HumanResources.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Domain.Entities
{
    public class Spent : IDate
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool? Accept { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public State State { get; set; }

        // Navigation

        public int PersonnelleId { get; set; }
        public Personnelle Personnelle { get; set; }
    }
}
