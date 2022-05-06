using HumanResources.Domain.Enums;
using HumanResources.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Domain.Entities
{
    public class Holiday : IDate
    {
        public int Id { get; set; }
        public string HolidayName { get; set; }
        public DateTime HolidayStart { get; set; }
        public DateTime HolidayEnd { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public State State { get; set; }

        // Navigation
        public int PersonnelleId { get; set; }
        public Personnelle Personnelle { get; set; }

        public int DirectorId { get; set; }
        public Director Director { get; set; }
    }
}
