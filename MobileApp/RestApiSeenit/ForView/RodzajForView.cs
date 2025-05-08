using RestApiSeenit.Models;
using RestApiSeenit.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiSeenit.ForView
{
    public class RodzajForView
    {

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Nazwa { get; set; } = null!;
        public static implicit operator Rodzaj(RodzajForView item)
            => new Rodzaj().CopyProperties(item);
        public static implicit operator RodzajForView(Rodzaj item)
            => new RodzajForView().CopyProperties(item);
    }
}
