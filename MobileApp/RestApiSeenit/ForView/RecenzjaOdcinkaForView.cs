using RestApiSeenit.Models;
using RestApiSeenit.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiSeenit.ForView
{
    public class RecenzjaOdcinkaForView
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "text")]
        public string Tresc { get; set; } = null!;
        public int? Ocena { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Data { get; set; }
        public int? UzytkownikId { get; set; }
        public int? OdcinekId { get; set; }
        public static implicit operator RecenzjaOdcinka(RecenzjaOdcinkaForView item)
            => new RecenzjaOdcinka().CopyProperties(item);
        public static implicit operator RecenzjaOdcinkaForView(RecenzjaOdcinka item)
            => new RecenzjaOdcinkaForView().CopyProperties(item);
    }
}
