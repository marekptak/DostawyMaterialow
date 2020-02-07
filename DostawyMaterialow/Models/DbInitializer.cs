using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DostawyMaterialow.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Dostawy.Any())
            {
                context.AddRange(
                    new Dostawa { Srednica=12, Gatunek="15CrMo", Wytop="WE23A2", Masa=120,
                                    Dlugosc=6500, DataDostawy="02.02.2020", Dostawca="FBG"},
                    new Dostawa { Srednica=10, Gatunek= "18H2N2", Wytop="WE23A6", Masa=2020,
                                    Dlugosc=6500, DataDostawy="02.02.2020", Dostawca="FBG"},
                    new Dostawa { Srednica=16, Gatunek="15CrMo", Wytop="WE24A", Masa=240,
                                    Dlugosc=6500, DataDostawy="02.02.2020", Dostawca="FBG"},
                    new Dostawa { Srednica=20, Gatunek= "20MnCr5", Wytop="WE33A", Masa=3120,
                                    Dlugosc=6500, DataDostawy="02.02.2020", Dostawca="FBG"},
                    new Dostawa { Srednica=42, Gatunek= "S355J2", Wytop="W123A", Masa=1120,
                                    Dlugosc=6500, DataDostawy="02.02.2020", Dostawca="FBG"}
                    );;
                context.SaveChanges();

            }
        }
    }
}
