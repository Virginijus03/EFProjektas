using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjektas.Models
{
    public class Dormitory : Location
    {
        public int RoomCount { get; set; }

        public virtual List<Student> Students { get; set; } 
    }
}
