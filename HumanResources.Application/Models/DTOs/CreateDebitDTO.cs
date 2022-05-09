using HumanResources.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResources.Application.Models.DTOs
{
    public class CreateDebitDTO
    {
        [Required(ErrorMessage = "Must to Type Debit")]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        [MaxLength(41, ErrorMessage = "Maximum lentht is 41")] // zimmet edilen alet adı ve parantez içerine seri numarası ile yazılmalıdır.
        public string DebitName { get; set; }

        public DateTime CreateDate => DateTime.Now;
        public State State => State.Active;

        [Required(ErrorMessage ="Must to Select Personel")]
        public int PersonelleId { get; set; }

        [Required(ErrorMessage = "Must to Select Director")] // Personel zimmet ataması sırasında yönetici kendini de atamalıdır.
        public int DirectorId { get; set; }
    }
}
