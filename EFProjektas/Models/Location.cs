using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjektas.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [MaxLength(300)]
        public string City { get; set; }

        [MaxLength(300)]
        public string Address { get; set; }

        [NotMapped]
        public string FullAddress => $"{Address}, {City}";
    }
}
