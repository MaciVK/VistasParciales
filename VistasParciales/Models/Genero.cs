using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VistasParciales.Models
{
    [Table("GENEROS")]
    public class Genero
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDGENERO")]
        public int IdGenero { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
    }
}
