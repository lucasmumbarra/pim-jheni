using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace pim.Models
{
    [Table("CADASTRO_FUNCIONARIO", Schema = "dbo")]
    public class CadastroFuncionario
    {
        [Key]
        [Column("CAD_INT_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("CAD_STR_NOME", TypeName = "VARCHAR(70)")]
        public string Nome { get; set; }

        [Required]
        [Column("CAD_STR_CPF", TypeName = "CHAR(11)")]
        public string CPF { get; set; }

        [Required]
        [Column("CAD_STR_RG", TypeName = "CHAR(9)")]
        public string RG { get; set; }

        [Required]
        [Column("CAD_DAT_DTNASCIMENTO", TypeName = "DATE")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Column("CAD_STR_FONE", TypeName = "CHAR(11)")]
        public string Telefone { get; set; }

        [Required]
        [Column("CAD_STR_EMAIL", TypeName = "VARCHAR(70)")]
        public string Email { get; set; }

        [Required]
        [Column("CAD_DAT_DTADMISSAO", TypeName = "DATE")]
        public DateTime DataAdmissao { get; set; }

        [Column("CAD_DAT_DTDEMISSAO", TypeName = "DATE")]
        public DateTime? DataDemissao { get; set; }

        [Required]
        [Column("CAR_INT_ID")]
        public int CargoId { get; set; }

        [Required]
        [Column("GEN_INT_ID")]
        public int GeneroId { get; set; }

        [Required]
        [Column("END_INT_ID")]
        public int EnderecoId { get; set; }

    }
}
