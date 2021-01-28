using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjektas.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [MaxLength(150)] 
        public string Title { get; set; }
        [Required]
        [MaxLength(150)]
        public string Duration { get; set; }

    }
}
