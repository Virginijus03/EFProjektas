using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjektasNet
{
    public class EFProjektasContext : DbContext
    {
        public EFProjektasContext() : base("EfProjektas")
        {
            System.Data.Entity.Database.SetInitializer(new EFProjektasContextInicializer());

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Dormitory> Dormitories { get; set; }
        public DbSet<Enrolment> Enrolments { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Location> Locations  { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Student> Students { get; set; }






    }
}
