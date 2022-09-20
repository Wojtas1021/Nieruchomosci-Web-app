using Microsoft.EntityFrameworkCore;
using Nieruchomosci.Data.Data.CMS;
using Nieruchomosci.Data.Data.Nieruchomosci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nieruchomosci.Data.Data
{
    public class NieruchomosciContext : DbContext
    {
        public NieruchomosciContext(DbContextOptions<NieruchomosciContext> options)
    : base(options)
        {
        }

        public DbSet<Strona>? Strona { get; set; }

        public DbSet<Aktualnosc>? Aktualnosc { get; set; }

        public DbSet<Parametr>? Parametr { get; set; }

        public DbSet<Post>? Post { get; set; }

        public DbSet<Rekomendacja>? Rekomendacja { get; set; }
        public DbSet<Nieruchomosc>? Nieruchomosc { get; set; }
        public DbSet<RodzajNieruchomosci>? RodzajNieruchomosci { get; set; }
        public DbSet<ElementKoszyka>? ElementKoszyka { get; set; }

    }
}

