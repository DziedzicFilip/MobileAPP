using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApiSeenit.Models
{
    [Table("Uzytkownik")]
    [Index("Email", Name = "UQ__Uzytkown__A9D10534FC6E1D65", IsUnique = true)]
    public partial class Uzytkownik
    {
        public Uzytkownik()
        {
            ListaObejrzanes = new HashSet<ListaObejrzane>();
            ListaObserwowanes = new HashSet<ListaObserwowane>();
            RecenzjaFilmus = new HashSet<RecenzjaFilmu>();
            RecenzjaOdcinkas = new HashSet<RecenzjaOdcinka>();
            RecenzjaSerialus = new HashSet<RecenzjaSerialu>();
            Ulubiones = new HashSet<Ulubione>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Email { get; set; } = null!;
        [StringLength(100)]
        public string Haslo { get; set; } = null!;
        [StringLength(50)]
        public string Nick { get; set; } = null!;

        [InverseProperty("Uzytkownik")]
        public virtual ICollection<ListaObejrzane> ListaObejrzanes { get; set; }
        [InverseProperty("Uzytkownik")]
        public virtual ICollection<ListaObserwowane> ListaObserwowanes { get; set; }
        [InverseProperty("Uzytkownik")]
        public virtual ICollection<RecenzjaFilmu> RecenzjaFilmus { get; set; }
        [InverseProperty("Uzytkownik")]
        public virtual ICollection<RecenzjaOdcinka> RecenzjaOdcinkas { get; set; }
        [InverseProperty("Uzytkownik")]
        public virtual ICollection<RecenzjaSerialu> RecenzjaSerialus { get; set; }
        [InverseProperty("Uzytkownik")]
        public virtual ICollection<Ulubione> Ulubiones { get; set; }
    }
}
