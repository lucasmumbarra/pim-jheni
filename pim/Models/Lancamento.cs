using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace pim.Models
{
    [Table("LANCAMENTO", Schema = "dbo")]
    public class Lancamento
    {
        [Key]
        [Column("LAN_INT_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("LAN_NUM_AUXHOMEOFFICE", TypeName = "NUMERIC(7,2)")]
        public decimal AuxilioHomeOffice { get; set; }

        [Required]
        [Column("LAN_NUM_AUXCOMBUSTIVEL", TypeName = "NUMERIC(7,2)")]
        public decimal AuxilioCombustivel { get; set; }

        [Required]
        [Column("LAN_NUM_SALARIOFAMILIA", TypeName = "NUMERIC(7,2)")]
        public decimal SalarioFamilia { get; set; }

        [Required]
        [Column("LAN_NUM_SALARIOBRUTO", TypeName = "NUMERIC(7,2)")]
        public decimal SalarioBruto { get; set; }

        [Required]
        [Column("LAN_NUM_SALARIOLIQUIDO", TypeName = "NUMERIC(7,2)")]
        public decimal SalarioLiquido { get; set; }

        [Required]
        [Column("LAN_NUM_ABONOSALARIAL", TypeName = "NUMERIC(7,2)")]
        public decimal AbonoSalarial { get; set; }

        [Required]
        [Column("LAN_NUM_FERIAS", TypeName = "NUMERIC(7,2)")]
        public decimal Ferias { get; set; }

        [Required]
        [Column("LAN_NUM_DECIMOTERCEIRO", TypeName = "NUMERIC(7,2)")]
        public decimal DecimoTerceiro { get; set; }

        [Required]
        [Column("LAN_NUM_ABONOFALTASATRASOS", TypeName = "NUMERIC(7,2)")]
        public decimal AbonoFaltasAtrasos { get; set; }

        [Required]
        [Column("LAN_NUM_ADCIONALNOTURNO", TypeName = "NUMERIC(7,2)")]
        public decimal AdicionalNoturno { get; set; }

        [Required]
        [Column("LAN_NUM_PLR", TypeName = "NUMERIC(7,2)")]
        public decimal PLR { get; set; }

        [Required]
        [Column("LAN_NUM_VLREFEICAO", TypeName = "NUMERIC(7,2)")]
        public decimal ValorRefeicao { get; set; }

        [Required]
        [Column("LAN_NUM_VLALIMENTACAO", TypeName = "NUMERIC(7,2)")]
        public decimal ValorAlimentacao { get; set; }

        [Required]
        [Column("LAN_NUM_VLTRANSPORTE", TypeName = "NUMERIC(7,2)")]
        public decimal ValorTransporte { get; set; }
    }
}
