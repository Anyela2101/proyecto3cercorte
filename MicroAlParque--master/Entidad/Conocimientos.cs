using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entidad
{
    public class Conocimientos
    {
        [Key]
        public int Codigo { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Pregunta1 { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Pregunta2 { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Pregunta3 { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Pregunta4 { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Pregunta5 { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Pregunta6 { get; set; }
         [Column(TypeName = "varchar(12)")]
        public string Idpersona{ get; set; }

    }
}