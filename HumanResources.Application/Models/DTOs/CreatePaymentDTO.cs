using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResources.Application.Models.DTOs
{
    public class PaymentDTO
    {
        [Required(ErrorMessage = "Must to Type Payment")]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        [MaxLength(21, ErrorMessage = "Maximum lentht is 21")]
        public string PaymentName { get; set; }

        [Required(ErrorMessage = "Must to Type Description")]
        [MinLength(21, ErrorMessage = "Minimum lenght is 21")]
        [MaxLength(140, ErrorMessage = "Maximum lentht is 140")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Must to Select Datetime")]
        public DateTime LastDayPay { get; set; }

        [Required(ErrorMessage = "Must to Select Director")]
        public int DirectorId { get; set; }
    }
}
