using RestApiSeenit.Models;
using RestApiSeenit.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiSeenit.ForView
{
    public class UlubioneForView
    {
        [Key]
        public int Id { get; set; }
        public int? UzytkownikId { get; set; }
        public int? FilmId { get; set; }
        public int? SerialId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataDodania { get; set; }
        public static implicit operator Ulubione(UlubioneForView item)
            => new Ulubione().CopyProperties(item);
        public static implicit operator UlubioneForView(Ulubione item)
            => new UlubioneForView().CopyProperties(item);
    }
}
