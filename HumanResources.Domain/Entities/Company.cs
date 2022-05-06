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
    public class Company : IDate
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Sector { get; set; }
        public string LogoPath { get; set; }

        [NotMapped]
        public IFormFile UploadLogo { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public State State { get; set; }

        //Navigation
        public int DirectorId { get; set; }
        public Director Director { get; set; }

    }
}
