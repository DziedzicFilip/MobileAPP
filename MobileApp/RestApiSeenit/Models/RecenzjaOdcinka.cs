using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApiSeenit.Models
{
    [Table("RecenzjaOdcinka")]
    public partial class RecenzjaOdcinka
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

        [ForeignKey("OdcinekId")]
        [InverseProperty("RecenzjaOdcinkas")]
        public virtual Odcinek? Odcinek { get; set; }
        [ForeignKey("UzytkownikId")]
        [InverseProperty("RecenzjaOdcinkas")]
        public virtual Uzytkownik? Uzytkownik { get; set; }
    }
}
