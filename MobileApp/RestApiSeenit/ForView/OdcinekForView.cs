using RestApiSeenit.Helpers;
using RestApiSeenit.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiSeenit.ForView
{
    public class OdcinekForView
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Tytul { get; set; } = null!;
        public int? NumerSezonu { get; set; }
        public int? NumerOdcinka { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataPremiery { get; set; }
        public int? SerialId { get; set; }
        public static implicit operator Odcinek(OdcinekForView item)
            => new Odcinek().CopyProperties(item);
        public static implicit operator OdcinekForView(Odcinek item)
            => new OdcinekForView().CopyProperties(item);
    }
}
