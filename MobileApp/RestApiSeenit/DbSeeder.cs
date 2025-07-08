using Microsoft.EntityFrameworkCore;
using RestApiSeenit.Models;
using RestApiSeenit.Models.Contexts;

namespace RestApiSeenit
{
    public static class DbSeeder
    {
        public static void Seed(this FilmyContext context)
        {
           /* // Tabela Rodzaj
            if (!context.Rodzajs.Any())
            {
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Rodzaj ON");
                context.Rodzajs.AddRange(
                    new Rodzaj { Nazwa = "Komedia" },
                    new Rodzaj { Nazwa = "Dokumentalny" }
                );
            }
            
            // Tabela Uzytkownik
            if (!context.Uzytkowniks.Any())
            {
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Uzytkownik ON");
                context.Uzytkowniks.Add(new Uzytkownik
                {
                    Email = "damian@grochowina.pl",
                    Haslo = "test123",
                    Nick = "Dgrochowina"
                });
            }

            // Tabela Serial
            if (!context.Serials.Any())
            {
                context.Serials.Add(new Serial
                {
                    Tytul = "Serial Test",
                    Opis = "Testowy opis serialu, super super serial",
                    DataStartu = new DateTime(2025, 5, 9),
                    RodzajId = 6,
                    UrlFoto = "def.png"
                });
            }

            // Tabela Film
            if (!context.Films.Any())
            {
                context.Films.AddRange(
                    new Film
                    {
                        Tytul = "21.37",
                        Opis = "Film o papiezu",
                        DataPremiery = new DateTime(2025, 5, 8),
                        RodzajId = 6,
                        UrlFoto = "O2137.jpg"
                    },
                    new Film
                    {
                        Tytul = "Minecraft Movie",
                        Opis = "Film o klockach",
                        DataPremiery = new DateTime(2025, 5, 9),
                        RodzajId = 5,
                        UrlFoto = "mc.jpg"
                    },
                    new Film
                    {
                        Tytul = "Test",
                        Opis = "Test",
                        DataPremiery = new DateTime(2025, 5, 9),
                        RodzajId = 6,
                        UrlFoto = "LegendaOchi.3.jpg"
                    },
                    new Film
                    {
                        Tytul = "Test2ddd",
                        Opis = "tddddddd",
                        DataPremiery = new DateTime(2025, 5, 9),
                        RodzajId = 5,
                        UrlFoto = "screamboat.jpg"
                    },
                    new Film
                    {
                        Tytul = "Testr",
                        Opis = "dasdsaads",
                        DataPremiery = new DateTime(2025, 5, 10),
                        RodzajId = 5,
                        UrlFoto = "def.png"
                    }
                );
            }

            context.SaveChanges();*/
        }
    }
}
