using HumanResources.Domain.Enums;
using HumanResources.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Domain.Entities
{
    public class AppUser : IdentityUser<int>, IUser, IDate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool? Gender { get; set; }
        public Status Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public State State { get; set; }

        // Navigation

        public int DirectorId { get; set; }
        public Director Director { get; set; }

        public int PersonnelleId { get; set; }
        public Personnelle Personnelle { get; set; }
    }
}
