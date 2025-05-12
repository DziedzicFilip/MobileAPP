using RestApiSeenit.Helpers;
using RestApiSeenit.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestApiSeenit.ForView
{
    public class ListaObejrzaneForView
    {
        [Key]
        public int Id { get; set; }
        public int? UzytkownikId { get; set; }
        public int? FilmId { get; set; }
        public int? SerialId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataDodania { get; set; }

        public static implicit operator ListaObejrzane(ListaObejrzaneForView item)
            => new ListaObejrzane().CopyProperties(item);
        public static implicit operator ListaObejrzaneForView(ListaObejrzane item)
            => new ListaObejrzaneForView().CopyProperties(item);
    }
}
