using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Projeto_Final.Models
{
    [Table("EntradaProduto")]
    public class EntradaProduto
    {
        [Column("Id")]
        [Display(Name = "Código do Entrada Produto")]
        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }

        public Produto? Produto { get; set; }

        [Column("EntradaData")]
        [Display(Name = "Data da Entrada ")]
        public DateTime EntradaData { get; set; }

        [Column("QuantidadeEntrada")]
        [Display(Name = "Quantidade Entrada")]
        public int QuantidadeEntrada { get; set; }
    }
}
