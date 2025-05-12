using RestApiSeenit.Models;
using RestApiSeenit.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiSeenit.ForView
{
    public class SerialForView
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Tytul { get; set; } = null!;
        [Column(TypeName = "text")]
        public string? Opis { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataStartu { get; set; }
        public string? UrlFoto { get; set; }
        public string? RodzajData { get; set; } = default!;
        public int? RodzajId { get; set; }
        public static implicit operator Serial(SerialForView item)
            => new Serial().CopyProperties(item);
        public static implicit operator SerialForView(Serial item)
            => new SerialForView()
            {
                RodzajData = item.Rodzaj?.Nazwa ?? string.Empty
            }.CopyProperties(item);
    }
}
