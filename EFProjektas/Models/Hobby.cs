using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjektas.Models
{
    public class Hobby
    {

        [Key]
        public int HobbyId { get; set; }
        [MaxLength(200)]
        public string TextLt { get; set; }
        public string Text { get; set; }
    }
}
