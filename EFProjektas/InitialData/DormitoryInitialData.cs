using EFProjektas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjektas.InitialData
{
    public static class DormitoryInitialData
    {
        public static readonly Dormitory[] DataSeed =
          {
                new Dormitory { LocationId = 1, Address = "Studentu g. 1", City = "Niu jorkas", RoomCount = 101 },
                new Dormitory { LocationId = 2, Address = "Studentu g. 2", City = "Niu jorkas", RoomCount = 114 },
                new Dormitory { LocationId = 3, Address = "Baraku g. 20", City = "Kamčiatka", RoomCount = 35 },
                new Dormitory { LocationId = 4, Address = "Baraku g. 21", City = "Kamčiatka", RoomCount = 32 },
                new Dormitory { LocationId = 5, Address = "Baraku g. 22", City = "Kamčiatka", RoomCount = 28 },
                new Dormitory { LocationId = 6, Address = "Baraku g. 23", City = "Kamčiatka", RoomCount = 40 },
                new Dormitory { LocationId = 7, Address = "Baraku g. 24", City = "Kamčiatka", RoomCount = 39 },
            };
    }
}
