using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Projeto_Final.Models
{
    [Table("Pais")]
    public class Pais
    {

        [Column("Id")]
        [Display(Name = "Código do Pais")]
        public int Id { get; set; }

        [Column("PaisNome")]
        [Display(Name = "Nome do Pais")]
        public string PaisNome { get; set; } = string.Empty;
    }
}
