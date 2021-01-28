using EFProjektas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjektas.InitialData
{
    public static class CourseInitialData
    {
        public static readonly Course[] DataSeed =
            {
                new Course { CourseId = 1, Duration="26", Title ="Finance"  },
                new Course { CourseId = 2, Duration="25", Title ="Marketing"  },
                new Course { CourseId = 3, Duration="20", Title ="Business Strategy"  },
                new Course { CourseId = 4, Duration="20", Title ="History"  },
                new Course { CourseId = 5, Duration="20", Title ="Music"  },
                new Course { CourseId = 6, Duration="20", Title ="Art"  },
                new Course { CourseId = 7, Duration="20", Title ="Software Development"  },
                new Course { CourseId = 8, Duration="20", Title ="Mobile and Web Development"  },
                new Course { CourseId = 9, Duration="20", Title ="Algorithms"  },
                new Course { CourseId = 10, Duration="20", Title ="Computer Security and Networks"  },
                new Course { CourseId = 11, Duration="20", Title ="Design and Product"  },
                new Course { CourseId = 12, Duration="20", Title ="Animal Health"  },
                new Course { CourseId = 13, Duration="20", Title ="Health Informatics"  },
                new Course { CourseId = 14, Duration="20", Title ="Healthcare Management"  },
                new Course { CourseId = 15, Duration="20", Title ="Nutrition"  },
                new Course { CourseId = 16, Duration="20", Title ="Patient Care"  },
                new Course { CourseId = 17, Duration="20", Title ="Public Health"  },
                new Course { CourseId = 18, Duration="20", Title ="Economics"  },
                new Course { CourseId = 19, Duration="20", Title ="Education"  },
                new Course { CourseId = 20, Duration="20", Title ="Goverment"  },
                new Course { CourseId = 21, Duration="20", Title ="Law"  },
            };
    }
}
