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
    public class Director : IUser ,IPersonnelle, IDate
    {
        public Director()
        {
            this.Personnelles = new HashSet<Personnelle>();
            this.Debits = new HashSet<Debit>();
            this.Holidays = new HashSet<Holiday>();
            this.Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string ImagePath { get; set; }

        [NotMapped]
        public IFormFile UploadPath { get; set; }

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

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int CommentId { get; set; }
        public Comment Comment { get; set; }

        public int MemberId { get; set; }
        public MemberShipProsedure MemberShipProsedure { get; set; }

        public ICollection<Personnelle> Personnelles { get; set; }
        public ICollection<Debit> Debits { get; set; }
        public ICollection<Holiday> Holidays { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
