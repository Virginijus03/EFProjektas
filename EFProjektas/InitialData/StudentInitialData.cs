using EFProjektas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjektas.InitialData
{
    public static class StudentInitialData
    {
        public static readonly Student[] DataSeed =
           {
               new Student {  PersonId = 1, StudentId = 1, DormitoryId = 1 },
               new Student { PersonId = 2, StudentId = 2, DormitoryId = 1 },
               new Student { PersonId = 3, StudentId = 3, DormitoryId = 2 },
               new Student { PersonId = 4, StudentId = 4, DormitoryId = 3 },
               new Student { PersonId = 5, StudentId = 5, DormitoryId = 2 },
               new Student { PersonId = 6, StudentId = 6, DormitoryId = 2 },
               new Student { PersonId = 7, StudentId = 7, DormitoryId = 1 },
               new Student { PersonId = 8, StudentId = 8, DormitoryId = 2 },
               new Student { PersonId = 9, StudentId = 9, DormitoryId = 2 },
               new Student { PersonId = 10, StudentId = 10, DormitoryId = 4 },
               new Student { PersonId = 11, StudentId = 11, DormitoryId = 5 },
               new Student { PersonId = 12, StudentId = 12, DormitoryId = 6 },
            };
    }
}
