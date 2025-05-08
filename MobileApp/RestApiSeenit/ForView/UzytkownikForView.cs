using RestApiSeenit.Models;
using RestApiSeenit.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiSeenit.ForView
{
    public class UzytkownikForView
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Email { get; set; } = null!;
        [StringLength(100)]
        public string Haslo { get; set; } = null!;
        [StringLength(50)]
        public string Nick { get; set; } = null!;
        public static implicit operator Uzytkownik(UzytkownikForView item)
            => new Uzytkownik().CopyProperties(item);
        public static implicit operator UzytkownikForView(Uzytkownik item)
            => new UzytkownikForView().CopyProperties(item);

    }
}
