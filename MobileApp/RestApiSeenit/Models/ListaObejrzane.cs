using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApiSeenit.Models
{
    [Table("ListaObejrzane")]
    public partial class ListaObejrzane
    {
        [Key]
        public int Id { get; set; }
        public int? UzytkownikId { get; set; }
        public int? FilmId { get; set; }
        public int? SerialId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataDodania { get; set; }

        [ForeignKey("FilmId")]
        [InverseProperty("ListaObejrzanes")]
        public virtual Film? Film { get; set; }
        [ForeignKey("SerialId")]
        [InverseProperty("ListaObejrzanes")]
        public virtual Serial? Serial { get; set; }
        [ForeignKey("UzytkownikId")]
        [InverseProperty("ListaObejrzanes")]
        public virtual Uzytkownik? Uzytkownik { get; set; }
    }
}
