using HumanResources.Domain.Entities;
using HumanResources.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResources.Application.Models.DTOs
{
    public class CreateCommentDTO
    {
        [Required(ErrorMessage="Must to Type Title")]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        [MaxLength(21,ErrorMessage ="Maximum lentht is 21")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Must to type content")]
        [MinLength(21, ErrorMessage = "Minimum content lenght is 21")]
        [MaxLength(140,ErrorMessage ="Maximum content lengt is 140")]
        public string Content { get; set; }

        public DateTime CreateDate => DateTime.Now;
        public Status Status => Status.Director;

    }
}
