using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApiSeenit.Models
{
    [Table("Film")]
    public partial class Film
    {

        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Tytul { get; set; } = null!;
        [Column(TypeName = "text")]
        public string? Opis { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataPremiery { get; set; }
        public int? RodzajId { get; set; }

        [ForeignKey("RodzajId")]
        [InverseProperty("Films")]
        public virtual Rodzaj? Rodzaj { get; set; }
        [InverseProperty("Film")]
        public virtual ICollection<ListaObejrzane> ListaObejrzanes { get; set; }
        [InverseProperty("Film")]
        public virtual ICollection<ListaObserwowane> ListaObserwowanes { get; set; }
        [InverseProperty("Film")]
        public virtual ICollection<RecenzjaFilmu> RecenzjaFilmus { get; set; }
        [InverseProperty("Film")]
        public virtual ICollection<Ulubione> Ulubiones { get; set; }
    }
}
