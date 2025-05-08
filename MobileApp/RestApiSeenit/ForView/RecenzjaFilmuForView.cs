using RestApiSeenit.Helpers;
using RestApiSeenit.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestApiSeenit.ForView
{
    public class RecenzjaFilmuForView
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "text")]
        public string Tresc { get; set; } = null!;
        public int? Ocena { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Data { get; set; }
        public int? UzytkownikId { get; set; }
        public int? FilmId { get; set; }
        public static implicit operator RecenzjaFilmu(RecenzjaFilmuForView item)
            => new RecenzjaFilmu().CopyProperties(item);
        public static implicit operator RecenzjaFilmuForView(RecenzjaFilmu item)
            => new RecenzjaFilmuForView().CopyProperties(item);
    }
}
