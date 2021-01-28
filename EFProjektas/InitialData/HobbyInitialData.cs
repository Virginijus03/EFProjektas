using EFProjektas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjektas.InitialData
{
    public static class HobbyInitialData
    {
        public static readonly Hobby[] DataSeed =
           {
                new Hobby { HobbyId = 1, Text="Astrology", TextLt = "Astrologija"  },
                new Hobby { HobbyId = 2, Text="Art", TextLt = "Menas"  },
                new Hobby { HobbyId = 3, Text="Animation", TextLt = "Animacija"  },
                new Hobby { HobbyId = 4, Text="Blogging", TextLt = "Tinklaraščių rašymas"  },
                new Hobby { HobbyId = 5, Text="Board games", TextLt = "Stalo žaidimai"  },
                new Hobby { HobbyId = 6, Text="Book reading", TextLt = "Knygų skaitymas"  },
                new Hobby { HobbyId = 7, Text="Card games", TextLt = "Kortų žaidimai"  },
                new Hobby { HobbyId = 8, Text="Chess", TextLt = "Šachmatai"  },
                new Hobby { HobbyId = 9, Text="Photograpy", TextLt = "Fotografija"  },
                new Hobby { HobbyId = 10, Text="Movies watching", TextLt = "Filmų žiūrėjimas"  },
                new Hobby { HobbyId = 11, Text="Running", TextLt = "Bėgimas"  },
                new Hobby { HobbyId = 12, Text="Football", TextLt = "Furbolas"  },
                new Hobby { HobbyId = 13, Text="Tennis", TextLt = "Tenisas"  },
                new Hobby { HobbyId = 14, Text="Museums", TextLt = "Muziejai"  },
                new Hobby { HobbyId = 15, Text="Music", TextLt = "Muzika"  },
                new Hobby { HobbyId = 16, Text="Cooking", TextLt = "Maisto gaminimas"  },
                new Hobby { HobbyId = 17, Text="Gymnastics", TextLt = "Gimnastika"  },
                new Hobby { HobbyId = 18, Text="Dancing", TextLt = "Šokiai"  },
                new Hobby { HobbyId = 19, Text="Computer games", TextLt = "Kompiuteriniai žaidimai"  },
                new Hobby { HobbyId = 20, Text="Yoga", TextLt = "Joga"  },
                new Hobby { HobbyId = 21, Text="Poetry", TextLt = "Poezija"  },
                new Hobby { HobbyId = 22, Text="Karaoke", TextLt = "Karaokė"  },
                new Hobby { HobbyId = 23, Text="Puzzles", TextLt = "Dėlionės"  },
                new Hobby { HobbyId = 24, Text="Craft", TextLt = "Rankdarbiai"  },
                new Hobby { HobbyId = 25, Text="Shopping", TextLt = "Apsipirkimas"  },
                new Hobby { HobbyId = 26, Text="Sewing", TextLt = "Siuvimas"  },
            };
    }
}
