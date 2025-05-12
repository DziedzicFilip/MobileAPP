using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApiSeenit.Models
{
    [Table("Ulubione")]
    public partial class Ulubione
    {
        [Key]
        public int Id { get; set; }
        public int? UzytkownikId { get; set; }
        public int? FilmId { get; set; }
        public int? SerialId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataDodania { get; set; }

        [ForeignKey("FilmId")]
        [InverseProperty("Ulubiones")]
        public virtual Film? Film { get; set; }
        [ForeignKey("SerialId")]
        [InverseProperty("Ulubiones")]
        public virtual Serial? Serial { get; set; }
        [ForeignKey("UzytkownikId")]
        [InverseProperty("Ulubiones")]
        public virtual Uzytkownik? Uzytkownik { get; set; }
    }
}
