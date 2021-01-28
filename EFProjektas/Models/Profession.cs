using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjektas.Models
{
    public class Profession
    {
        [Key]
        public int ProfessionId { get; set; }
        [MaxLength(200)]
        public string Text { get; set; }

    }
}
