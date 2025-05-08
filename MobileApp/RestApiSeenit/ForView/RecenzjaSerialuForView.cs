using RestApiSeenit.Models;
using RestApiSeenit.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiSeenit.ForView
{
    public class RecenzjaSerialuForView
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "text")]
        public string Tresc { get; set; } = null!;
        public int? Ocena { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Data { get; set; }
        public int? UzytkownikId { get; set; }
        public int? SerialId { get; set; }
        public static implicit operator RecenzjaSerialu(RecenzjaSerialuForView item)
            => new RecenzjaSerialu().CopyProperties(item);
        public static implicit operator RecenzjaSerialuForView(RecenzjaSerialu item)
            => new RecenzjaSerialuForView().CopyProperties(item);
    }
}
