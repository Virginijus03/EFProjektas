using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjektas.Models
{
     public class Person
    {
        [Key]
        public int PersonId { get; set; }  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        /// <summary>Ugis</summary>
        public int Height { get; set; }

        /// <summary>Svoris</summary>
        public decimal Weight { get; set; }

        public string Biography { get; set; }

        [NotMapped]
        public int? Age
        {
            get
            {
                if (BirthDate == null) return null;
                else
                {
                    var timeSpan = DateTime.Now.Subtract((DateTime)BirthDate);
                    return new DateTime(timeSpan.Ticks).Year - 1;
                }
            }
        }

    }
}
