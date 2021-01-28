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

        }
    }
}
