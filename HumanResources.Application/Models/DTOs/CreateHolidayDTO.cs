using HumanResources.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResources.Application.Models.DTOs
{
    public class CreateHolidayDTO
    {
        [Required(ErrorMessage = "Must to Type Holiday")]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        [MaxLength(41, ErrorMessage = "Maximum lentht is 41")]
        public string HolidayName { get; set; }

        [Required(ErrorMessage ="Must to select Date Start")]
        [DataType(DataType.Date)]

        //public class DateTimeRangeAtt : RangeAttribute
        //{
        //    public DateTimeRangeAtt()
        //      : base(typeof(DateTime),
        //            new DateTime(1, 1, 1920).ToShortDateString(),
        //            new DateTime(1, 1, DateTime.Now.Year - 18).ToShortDateString()) // İzin seçerken geçmişten seçilmesin diye sınırlama yapmak gerekiyor.
        //    { }                                                                     // Sınırlama Kodu
        //}
        //[DateTimeRangeAtt]
        //public DateTime dateOfBirth { get; set; }


        public DateTime HolidayStart { get; set; }
        [Required(ErrorMessage = "Must to select Date End")]
        public DateTime HolidayEnd { get; set; }

        public DateTime CreateDate => DateTime.Now;

        public State State => State.Active;

        [Required(ErrorMessage = "Must to Select Personel")]
        public int PersonelleId { get; set; }

        [Required(ErrorMessage = "Must to Select Director")]
        public int DirectorId { get; set; }
    }
}
