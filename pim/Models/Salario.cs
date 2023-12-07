using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace pim.Models
{
    [Table("SALARIO", Schema = "dbo")]
    public class Salario
    {
        [Key]
        [Column("SAL_INT_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("SAL_NUM_VALORSALARIO", TypeName = "NUMERIC(7,2)")]
        public decimal ValorSalario { get; set; }

        [Required]
        [Column("COM_INT_ID")]
        public int ComissaoId { get; set; }

    }
}