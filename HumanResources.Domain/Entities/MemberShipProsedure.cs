using HumanResources.Domain.Enums;
using HumanResources.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Domain.Entities
{
    public class MemberShipProsedure : IDate
    {
        public int Id { get; set; }
        public bool? Accept { get; set; }
        public DateTime MemberStart { get; set; }
        public DateTime MemberEnd { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public State State { get; set; }

        // Navigation
        public int DirectorId { get; set; }
        public Director Director { get; set; }
    }
}
