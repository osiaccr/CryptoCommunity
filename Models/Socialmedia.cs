using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoCommunity.Models
{ 
    public class Socialmedia
    {
  
        [Key]
        public int Id { get; set; }

        public int SocialmediaTypeId { get; set; }

        [ForeignKey("SocialmediaTypeId")]
        public virtual SocialmediaType SocialmediaType { get; set; }

        public int ListingId { get; set; }

        [ForeignKey("ListingId")]
        public virtual Listing Listing { get; set; }

        public string Data { get; set; }

    }
}
