using HumanResources.Domain.Enums;
using HumanResources.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Domain.Entities
{
    public class Personnelle :IUser, IPersonnelle, IDate
    {
        public Personnelle()
        {
            this.Debits = new HashSet<Debit>();
            this.FlexDays = new HashSet<FlexDay>();
            this.Holidays = new HashSet<Holiday>();
            this.Spents = new HashSet<Spent>();
            this.TurnOfWorks = new HashSet<TurnOfWork>();
        }
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool? Gender { get; set; }

        public decimal Salary { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public State State { get; set; }

        // Navigation
        public int DirectorId { get; set; }
        public Director Director { get; set; }

        public ICollection<Debit> Debits { get; set; }
        public ICollection<FlexDay> FlexDays { get; set; }
        public ICollection<Holiday> Holidays { get; set; }
        public ICollection<Spent> Spents { get; set; }
        public ICollection<TurnOfWork> TurnOfWorks { get; set; }
    }
}
