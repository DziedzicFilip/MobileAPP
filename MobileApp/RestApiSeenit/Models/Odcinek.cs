using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApiSeenit.Models
{
    [Table("Odcinek")]
    public partial class Odcinek
    {
        public Odcinek()
        {
            RecenzjaOdcinkas = new HashSet<RecenzjaOdcinka>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Tytul { get; set; } = null!;
        public int? NumerSezonu { get; set; }
        public int? NumerOdcinka { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataPremiery { get; set; }
        public int? SerialId { get; set; }

        [ForeignKey("SerialId")]
        [InverseProperty("Odcineks")]
        public virtual Serial? Serial { get; set; }
        [InverseProperty("Odcinek")]
        public virtual ICollection<RecenzjaOdcinka> RecenzjaOdcinkas { get; set; }
    }
}
