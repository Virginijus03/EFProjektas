using EFProjektas.InitialData;
using EFProjektas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjektas
{
     public class EFProjektasContextInicializer : CreateDatabaseIfNotExists<EFProjektasContext>
    {
        protected override void Seed(EFProjektasContext context)
        {
            context.Courses.AddRange(CourseInitialData.DataSeed);
            context.Dormitories.AddRange (DormitoryInitialData.DataSeed);
            context.Persons.AddRange(PersonInitialData.DataSeed);
            context.Professions.AddRange(ProfesionalInitialData.DataSeed);
            context.Students.AddRange(StudentInitialData.DataSeed);
            context.Hobbies.AddRange(HobbyInitialData.DataSeed);

        }

        private IEnumerable<Hobby> ParseHobbies(IEnumerable<string> hobbies)
        {
            foreach (string line in hobbies)
            {
                var stringSplit = line.Split(',') ;
                yield return new Hobby { HobbyId = int.Parse(stringSplit[0]), Text = stringSplit[1], TextLt = stringSplit[2] };
            }
                

            
            
        }
     }
}
 