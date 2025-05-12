using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApiSeenit.Models
{
    [Table("RecenzjaFilmu")]
    public partial class RecenzjaFilmu
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

        [ForeignKey("FilmId")]
        [InverseProperty("RecenzjaFilmus")]
        public virtual Film? Film { get; set; }
        [ForeignKey("UzytkownikId")]
        [InverseProperty("RecenzjaFilmus")]
        public virtual Uzytkownik? Uzytkownik { get; set; }
    }
}
