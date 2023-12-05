using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Projeto_Final.Models
{
    [Table("SaidaProduto")]
    public class SaidaProduto
    {
        [Column("Id")]
        [Display(Name = "Código da Saida Produto ")]
        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }

        public Produto? Produto { get; set; }

        [Column("SaidaData")]
        [Display(Name = "Data da Saida ")]
        public DateTime SaidaData { get; set; }

        [Column("QuantidadeSaida")]
        [Display(Name = "Quantidade Saída ")]
        public int QuantidadeSaida { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }

        [ForeignKey("TipoSaidaId")]
        public int TipoSaidaId { get; set; }

        public TipoSaida? TipoSaida { get; set; }

        

        
    }
}
