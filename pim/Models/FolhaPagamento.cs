using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace pim.Models
{
    [Table("FOLHA_PAGAMENTO", Schema = "dbo")]
    public class FolhaPagamento
    {
        [Key]
        [Column("FOL_INT_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("FOL_DAT_MESREFERENCIA", TypeName = "DATE")]
        public DateTime MesReferencia { get; set; }

        [Required]
        [Column("FOL_STR_DIASTRABALHADOS", TypeName = "VARCHAR(10)")]
        public string DiasTrabalhados { get; set; }

        [Required]
        [Column("FOL_STR_HORASTRABALHADAS", TypeName = "VARCHAR(10)")]
        public string HorasTrabalhadas { get; set; }

        [Required]
        [Column("FOL_STR_BANCOHORAS", TypeName = "VARCHAR(10)")]
        public string BancoHoras { get; set; }

        [Required]
        [Column("DES_INT_ID")]
        public int DescontoId { get; set; }

        [Required]
        [Column("LAN_INT_ID")]
        public int LancamentoId { get; set; }
    }
}
