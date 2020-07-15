using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoCommunity.Models
{
    public class Listing
    { 
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(25, ErrorMessage = "Numele trebuie sa fie de maxim 25 de caractere")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        
        [Required]
        [StringLength(350, ErrorMessage = "Descrierea scurta trbuie sa fie de maxim 150 de caracter")]
        public string ShortDestription { get; set; }
        
        public string PhotoURL { get; set; }

        public string SocialmediaList { get; set; }

        public int ListingTypeId { get; set; }

        [ForeignKey("ListingTypeId")]
        public virtual ListingType Type { get; set; }
        
        public DateTime DateAdded { get; set; }

        public bool IsVisible { get; set; }
        
        public bool IsAddedBySelf { get; set; }
    }
}
