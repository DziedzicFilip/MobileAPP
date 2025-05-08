using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApiSeenit.Models
{
    [Table("RecenzjaSerialu")]
    public partial class RecenzjaSerialu
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

        [ForeignKey("SerialId")]
        [InverseProperty("RecenzjaSerialus")]
        public virtual Serial? Serial { get; set; }
        [ForeignKey("UzytkownikId")]
        [InverseProperty("RecenzjaSerialus")]
        public virtual Uzytkownik? Uzytkownik { get; set; }
    }
}
