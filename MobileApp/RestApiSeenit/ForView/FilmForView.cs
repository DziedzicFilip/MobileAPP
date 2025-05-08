using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using RestApiSeenit.Helpers;
using RestApiSeenit.Models;

namespace RestApiSeenit.ForView
{
    public class FilmForView 
    {
        [Key]
        public int Id { get; set; }
        public string Tytul { get; set; } = null!;
        public string? Opis { get; set; }
        public DateTime? DataPremiery { get; set; }
        public int? RodzajId { get; set; }

        public static implicit operator Film(FilmForView cli)
            => new Film().CopyProperties(cli);
        public static implicit operator FilmForView(Film cli)
            => new FilmForView().CopyProperties(cli);
    }
}
