using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace pim.Models
{
    [Table("FUNCIONARIO", Schema = "dbo")]
    public class Funcionario
    {
        [Key]
        [Column("FUN_INT_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("END_INT_ID")]
        public int EnderecoId { get; set; }

        [Required]
        [Column("CAR_INT_ID")]
        public int CargoId { get; set; }

        [Required]
        [Column("CON_INT_ID")]
        public int ContaBancariaId { get; set; }

        [Required]
        [Column("GEN_INT_ID")]
        public int GeneroId { get; set; }

        [Required]
        [Column("SAL_INT_ID")]
        public int SalarioId { get; set; }

        [Required]
        [Column("DEP_INT_ID")]
        public int DependenteId { get; set; }

        [Required]
        [Column("CAD_INT_ID")]
        public int CadastroFuncionarioId { get; set; }

    }
}
