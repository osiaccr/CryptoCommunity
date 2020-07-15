using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoCommunity.Models
{
    public class SocialmediaType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string ButtonClass { get; set; }

        public string IconClass { get; set; }
    }
}
