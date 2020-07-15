using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoCommunity.Models
{
    public class ApplyFormModel
    {
        [Display(Name = "Nume")]
        [Required(ErrorMessage = "Campul {0} este obligatoriu")]
        [StringLength(25, ErrorMessage = "Campul {0} poate avea maxim {1} de caractere")]
        public string Name { get; set; }

        [Display(Name = "Descriere")]
        [Required(ErrorMessage = "Campul {0} este obligatoriu")]
        public string Description { get; set; }

        [Display(Name = "Descriere Scurta")]
        [Required(ErrorMessage = "Campul {0} este obligatoriu")]
        [StringLength(350, ErrorMessage = "Campul {0} poate avea maxim {1} de caractere")]
        public string ShortDestription { get; set; }

        [Display(Name = "Date de Contact")]
        [Required(ErrorMessage = "Campul {0} este obligatoriu")]
        public string SocialmediaList { get; set; }

        [Display(Name = "Tipul de postare")]
        [Required(ErrorMessage = "Campul {0} este obligatoriu")]
        public int ListingTypeId { get; set; }

        [ForeignKey("ListingTypeId")]
        public virtual ListingType Type { get; set; }

        [Display(Name = "Imagine")]
        [Required(ErrorMessage = "Campul {0} este obligatoriu")]
        public IFormFile File { get; set; }

    }
}
