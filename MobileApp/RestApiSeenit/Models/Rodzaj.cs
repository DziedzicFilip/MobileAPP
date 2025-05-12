using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApiSeenit.Models
{
    [Table("Rodzaj")]
    public partial class Rodzaj
    {
        public Rodzaj()
        {
            Films = new HashSet<Film>();
            Serials = new HashSet<Serial>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Nazwa { get; set; } = null!;

        [InverseProperty("Rodzaj")]
        public virtual ICollection<Film> Films { get; set; }
        [InverseProperty("Rodzaj")]
        public virtual ICollection<Serial> Serials { get; set; }
    }
}
