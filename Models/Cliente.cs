using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Projeto_Final.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Código do Cliente ")]
        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome do Cliente")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Data do Nascimento ")]
        public DateTime DataNascimento { get; set; }

        [Column("ClienteCpf")]
        [Display(Name = "Cpf do Cliente")]
        public string ClienteCpf { get; set; } = string.Empty;

        [Column("ClienteEndereco")]
        [Display(Name = "Endereço do Cliente")]
        public string ClienteEndereco { get; set; } = string.Empty;

        [Column("ClienteNumeroCasa")]
        [Display(Name = "Número da Casa do Cliente")]
        public string ClienteNumeroCasa { get; set; } = string.Empty;

        [Column("ClienteBairro")]
        [Display(Name = "Bairro do Cliente")]
        public string ClienteBairro { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }

        [Column("ClienteTelefone")]
        [Display(Name = "Telefone do Cliente")]
        public string ClienteTelefone { get; set; } = string.Empty;
    }
}
