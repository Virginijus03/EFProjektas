using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjektas.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; } 
        public int PersonId { get; set; }
        public int DormitoryId { get; set; } 


        public virtual Dormitory Dormitory { get; set; }
        public virtual Person Person { get; set; }
    }
}
