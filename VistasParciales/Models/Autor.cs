using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VistasParciales.Models
{
    [Table("AUTORES")]
    public class Autor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDAUTOR")]
        public int IdAutor { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("IDGENERO")]
        public int IdGenero{ get; set; }

    }
}
