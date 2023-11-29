using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Projeto_Final.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {
        [Column("TipoSaidaId")]
        [Display(Name = "Código do Tipo Saida")]
        public int TipoSaidaId { get; set; }

        [Column("TipoSaidaDescricao")]
        [Display(Name = "Descrição do Tipo Saida")]
        public string TipoSaidaDescricao { get; set; } = string.Empty;
    }
}
