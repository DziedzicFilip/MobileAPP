using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApiSeenit.Models
{
    [Table("Serial")]
    public partial class Serial
    {
        public Serial()
        {
            ListaObejrzanes = new HashSet<ListaObejrzane>();
            ListaObserwowanes = new HashSet<ListaObserwowane>();
            Odcineks = new HashSet<Odcinek>();
            RecenzjaSerialus = new HashSet<RecenzjaSerialu>();
            Ulubiones = new HashSet<Ulubione>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Tytul { get; set; } = null!;
        [Column(TypeName = "text")]
        public string? Opis { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataStartu { get; set; }
        public int? RodzajId { get; set; }
        public string? UrlFoto { get; set; }

        [ForeignKey("RodzajId")]
        [InverseProperty("Serials")]
        public virtual Rodzaj? Rodzaj { get; set; }
        [InverseProperty("Serial")]
        public virtual ICollection<ListaObejrzane> ListaObejrzanes { get; set; }
        [InverseProperty("Serial")]
        public virtual ICollection<ListaObserwowane> ListaObserwowanes { get; set; }
        [InverseProperty("Serial")]
        public virtual ICollection<Odcinek> Odcineks { get; set; }
        [InverseProperty("Serial")]
        public virtual ICollection<RecenzjaSerialu> RecenzjaSerialus { get; set; }
        [InverseProperty("Serial")]
        public virtual ICollection<Ulubione> Ulubiones { get; set; }
    }
}
